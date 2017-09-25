using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;

namespace Mirza09112017.com.week30
{
    public static class ExAutoMapper
    {

        //public IMapper GetAndConfigureMapper()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Person, Employee>()
        //        .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FirstName))
        //        .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LastName));

        //    });
        //    IMapper mapper = config.CreateMapper();

        //}

        public static void SetupAutomapper()
        {
            Mapper.CreateMap<Person, Customer>()
                .ForMember(cust => cust.Salary, per => per.Ignore())
                .ReverseMap();

            Mapper.CreateMap<Person, Employee>()
                .ForMember(emp => emp.FName, per => per.MapFrom(p => p.FirstName))
                .ForMember(emp => emp.LName, per => per.MapFrom(p => p.LastName))
                .ForMember(emp => emp.Salary, per => per.Ignore())
                .ReverseMap()
                .ForMember(emp => emp.FirstName, per => per.MapFrom(p => p.FName))
                .ForMember(emp => emp.LastName, per => per.MapFrom(p => p.LName));

            // Needed only for reverse map
            Mapper.CreateMap<AccountDto, Customer>();
            Mapper.CreateMap<Account, AccountDto>()
                .ForMember(emp => emp.FirstName, per => per.MapFrom(p => p.Customer.FirstName))
                .ForMember(emp => emp.LastName, per => per.MapFrom(p => p.Customer.LastName))
                .ForMember(emp => emp.Salary, per => per.MapFrom(p => p.Customer.Salary))
                .ReverseMap()
                // Means Map Customer from the Src(Account Dto) to do this you need to map
                // Account DTO to customer
                //.ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src))

            // Do the same above with Function Delegate or Static method
                .ForMember(dest => dest.Customer, opt => opt.ResolveUsing(src => {
                    return new Customer
                    {
                        FirstName = src.FirstName,
                        LastName = src.LastName,
                        Salary = src.Salary
                    };
                }));

            Mapper.CreateMap<AccountDto, Account>().ConvertUsing(MapCustomerFromDto);
            // or
            Mapper.CreateMap<AccountDto, Account>().ConvertUsing((accountDto) => {
                var account = new Account();
                account.AccountId = accountDto.AccountId;
                account.Year = accountDto.Year;
                account.Customer = Mapper.Map<Customer>(accountDto);
                return account;
            });

            // For Destination if the DTO has an object 
            // Mapper.CreateMap<AccountDto, Account>()
            //    .ForMember(dest => dest.Customer.Name, )

            // Customer Properties are not accessable in ForMember
            //.ForMember(dest => dest.Customer.Name, opt => opt.MapFrom(src => src.FirstName )

            // All Destination Members are validated not the source            
            Mapper.AssertConfigurationIsValid();

        }

        public static Account MapCustomerFromDto(AccountDto accountDto)
        {
            var account = new Account();
            account.AccountId = accountDto.AccountId;
            account.Year = accountDto.Year;
            account.Customer = Mapper.Map<Customer>(accountDto);
            return account;
        }



        public static void Main(string[] arg)
        {
            var person = new Person() { FirstName ="Alex", LastName ="Rod"};
            var customer = new Customer();
            var employee = new Employee();

            // Mapper.CreateMap<Person, Customer>().ReverseMap(); // Auto Maps same name property
                                                                  // Property without mapping are by default ignore

            // Define Mapping For Member 
            Mapper.CreateMap<Person, Customer>()
                //.ForMember(cust => cust.Salary,per => per.UseValue(10.0))
                .ForMember(cust => cust.Salary,per => per.Ignore())
                //.ForMember(cust => cust.Salary,per => per.MapFrom(p => p.Feild))
                .ReverseMap();

            // Check the rules on the mapping configuration and if something being ignored by default 
            // or has a member that has not mapping and is being defaulted to ignore
            Mapper.AssertConfigurationIsValid();

            // Not needed Mapper.Map<Person,Customer>(person, customer)
            Mapper.Map(person, customer);
            // customer = Mapper.Map<Person,Customer>(person)
            // customer = Mapper.Map<Customer>(person) Only Destination
            
            // Reverse
            // Mapper.CreateMap<Customer, Person>(); // OR use .ReverseMap
            var customer2 = new Customer() { FirstName = "Mac", LastName = "Windows" };
            var person2 = Mapper.Map<Person>(customer2);

            Mapper.CreateMap<Person, Employee>()
                .ForMember(emp => emp.FName, per => per.MapFrom(p => p.FirstName))
                .ForMember(emp => emp.LName, per => per.MapFrom(p => p.LastName))
                .ForMember(emp => emp.Salary, per => per.Ignore())
                .ReverseMap();

            Mapper.Map(person, employee);
        }
    }
}

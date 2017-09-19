using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public class MyClass
    {
        public int x { get; set; }

        [Description("This is the y value")]
        public int y { get; set; }


        public int Sum()
        {
            return x + y;
        }
    }
        public class PositiveValueClass
        {
            [NonNegative]
            public int x { get; set; }

            [NonNegative]
            public int y { get; set; }

            //[Remark("z value")]
            public int z { get; set; }

            public int Sum()
            {
                return x + y;
            }

        }

    [RemarkAttribute("This class uses an attribute.")]
    class UseAttrib
    {
        //Use of word Attribute is optional.
        [Remark("This property uses an attribute.")]
        public int x { get; set; }

        // ...
    }



    public class ExAttribute
    {

        static void Main()
        {
            MyClass myclassobj = new MyClass();
            myclassobj.y = 20;
            Type t = typeof(MyClass);
            //Type t = myclassobj.GetType(); // use .GetType() if you want to see what type of object it is.

            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo p in pi)
            {
                Console.WriteLine(p.Name);
                //var attributes = p.GetCustomAttributes();
                var attributes = p.GetCustomAttributesData();
                foreach (var att in attributes)
                {
                    Console.WriteLine(att);
                    Console.WriteLine(att.AttributeType.Name);
                    Console.WriteLine(p.GetValue(myclassobj));

                }

                Console.WriteLine("");

            }

            Type t3 = typeof(UseAttrib);

            Console.Write("Attributes in " + t3.Name + ": ");

            //the false here is do not include inherited attributes.
            var attribs = t3.GetCustomAttributes(false);
            foreach (var o in attribs)
            {
                Console.WriteLine(o);
            }

            Console.Write("Remark: ");

            // Retrieve the RemarkAttribute.
            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute)
                  Attribute.GetCustomAttribute(t3, tRemAtt);
            Console.WriteLine(ra.Remark);

            PositiveValueClass posClass = new PositiveValueClass();
            posClass.x = 10;
            posClass.y = -1;

            //Validator.ValidateNonNegative(posClass);
            posClass.ValidateNonNegative();

            //Type t2 = typeof(PositiveValueClass);
            //PropertyInfo[] pi2 = t2.GetProperties();
            //foreach (PropertyInfo p in pi2)
            //{
            //    Console.WriteLine(p.Name);
            //    //var attributes = p.GetCustomAttributes();
            //    var attributes = p.GetCustomAttributesData();
            //    foreach (var att in attributes)
            //    {
            //        if (att.AttributeType.Name == "NonNegative")
            //        {
            //            if (Convert.ToInt32(p.GetValue(posClass)) < 0)
            //                throw new ArgumentException(p.Name +
            //                " has a property with a value < 0.");
            //        }


            //    }

            //    Console.WriteLine("");

            //}

            Console.ReadKey();
        }
    }

}

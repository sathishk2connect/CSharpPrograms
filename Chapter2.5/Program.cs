using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Reflection;


namespace Chapter2._5
{
    [DataContract(Name="Myclass")]
    class MyClass
    {
        private int myRollNo;
        private int myValues;

        public int MyRollNo { get; set; }
        public int MyValues { get; set; }
    }

    [Helper]
    class HelperClass2
    {

    }

    [Helper]
    class HelperClass1
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
           // Console.WriteLine(Attribute.IsDefined(typeof(MyClass), typeof(SerializableAttribute)));
           // DataContractAttribute dA = (DataContractAttribute)Attribute.GetCustomAttribute(typeof(MyClass), typeof(DataContractAttribute));
            
            // Console.WriteLine(dA.Name);

            /*
            foreach (FieldInfo f in typeof(MyClass).GetFields(BindingFlags.NonPublic |
                         BindingFlags.Instance))
            {
                Console.WriteLine(f.Name);
            }
            foreach(PropertyInfo f in typeof(MyClass).GetProperties())
            {
                Console.WriteLine(f.Name);
            }
             * */

             
          
            Console.ReadKey();
        }
    }
}

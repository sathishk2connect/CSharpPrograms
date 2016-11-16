using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Web.Script.Serialization.JavaScriptSerializer;

namespace Chapter4._2
{
    public class Program
    {
        [Serializable]
        public class Employee
        {
            public string EmpName { get; set; }
            public string EmpID { get; set; }
            public DateTime DOB { get; set; }
            public double Salary { get; set; }
        }

        public static void XMLSerializeWrite()
        {
            Employee e1 = new Employee
            {
                EmpName = "Suresh",
                EmpID = "DF344353",
                DOB = DateTime.Parse("1988-02-01"),
                Salary = 4000
            };
            XmlSerializer x = new XmlSerializer(e1.GetType());
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            Console.WriteLine(filePath);
            FileInfo f = new FileInfo(filePath);
            StreamWriter fs = f.CreateText();
            x.Serialize(fs, e1);
            fs.Close();
            fs.Dispose();
        }

        public static void BinarySerializeWrite()
        {

            Employee e1 = new Employee
            {
                EmpName = "Suresh",
                EmpID = "DF344353",
                DOB = DateTime.Parse("1988-02-01"),
                Salary = 4000
            };
            IFormatter formatter = new BinaryFormatter();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            FileInfo f = new FileInfo(filePath);
            FileStream fs = f.OpenWrite();
            formatter.Serialize(fs, e1);
            fs.Close();
            fs.Dispose();
        }

        public static void JsonSerializeWrite()
        {
            Employee e1 = new Employee
            {
                EmpName = "Suresh",
                EmpID = "DF344353",
                DOB = DateTime.Parse("1988-02-01"),
                Salary = 4000
            };
           /* JavascriptSerializer x= new JsonSerializer();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            FileInfo f = new FileInfo(filePath);
            StreamWriter fs = f.CreateText();
            x.Serialize(fs, e1);
            fs.Close();
            fs.Dispose(); */
        }

        public static void BinarySerializeRead()
        {
            IFormatter formatter = new BinaryFormatter();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            FileInfo f = new FileInfo(filePath);
            FileStream fs = f.OpenRead();
            Employee emp = (Employee) formatter.Deserialize(fs);
            Console.WriteLine(emp.EmpName + " " + emp.EmpID);
            fs.Close();
            fs.Dispose();
        }

        public static void XMLSerializeRead()
        {
            XmlSerializer x = new XmlSerializer(new Employee().GetType());
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            FileInfo f = new FileInfo(filePath);
            StreamReader fs = f.OpenText();
            Employee emp = (Employee) x.Deserialize(fs);
            Console.WriteLine(emp.EmpName + " " + emp.EmpID);
            fs.Close();
            fs.Dispose();
        }

        public static void JsonSerializeRead()
        {
           /* JsonSerializer x = new JsonSerializer();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Employee.dat");
            FileInfo f = new FileInfo(filePath);
            StreamReader fs = f.OpenText();
            Employee emp = (Employee) x.Deserialize(fs, typeof(Employee));
            Console.WriteLine(emp.EmpName + " " + emp.EmpID);
            fs.Close();
            fs.Dispose(); */
        }

        static void Main(string[] args)
        {
            XMLSerializeWrite();
            XMLSerializeRead();
            BinarySerializeWrite();
            BinarySerializeRead();
            JsonSerializeWrite();
            JsonSerializeRead();
            Console.ReadKey();
        }
    }
}

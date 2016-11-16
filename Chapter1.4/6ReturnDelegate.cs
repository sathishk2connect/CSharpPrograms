using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._4
{

    public class Mydelegate
    {
        public delegate string Send();

        private string SendSecretMessage(){
            return "I am sending secret text";
        }

        public Send SendToAuthorized(string user){
             if("FRIEND".Equals(user)){
                Send sc = SendSecretMessage;
                return sc;
             }
             throw new Exception("UnAuthorized User");
        }
    }
    class ReturnDelegate
    {

        public static void Main()
        {
            Mydelegate d = new Mydelegate();
            Mydelegate.Send s = d.SendToAuthorized("FRIEND");
            Console.WriteLine(s());
            Console.ReadKey();
        }
    }
}

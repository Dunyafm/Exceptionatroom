using System;

namespace ExceptionsatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

                string userName = "Seid126";
                string pass = "1234";

                if(pass != " 0 ")

                throw new Exception("Get sonra gelersen"); //burda exception cixart!!


                Account account = new Account();
                account.Login(userName, pass);



          

         




















        }
    }
}

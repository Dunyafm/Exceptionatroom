using ExceptionsatRoom.Constants;
using ExceptionsatRoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsatRoom
{
   public class Account
   {
        public void Login(string userName, string password)
        {
            try
            {
                if (userName != "Seid126" || password != "1234")
                {

                    throw new LoginException(Messages.LoginMessage);


                }
                else
                {

                    Console.WriteLine("Login was success");


                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            
            


               
            
        }
        

   }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1996 && gamer.FirstName=="Halil İbrahim" && gamer.LastName=="Bircan" &&gamer.IdentityNumber==40456660090)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

﻿using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class MainMenuModel
    {
        public bool CheckClientsExistence(string PersonalID)
        {
            return new AccountRepository().CheckAccountExistence(new ClientRepository().CheckClientExistence(PersonalID));
            
        }
    }
}

using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class MainMenuModel
    {
        public bool CheckClientsExistence(string PersonalID)
        {
            if (new ClientRepository().CheckClientExistence(PersonalID)>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataSet GetTopClients()
        {
            return new AccountRepository().GetTopClients();
        }

        public DataSet GetBankAssets()
        {
            return new AccountRepository().GetBankAssets();
        }

        public DataSet GetNumberOfAccounts()
        {
            return new AccountRepository().GetNumberOfAccounts();
        }

        public DataSet GetAverageAccountPerPerson()
        {
            return new AccountRepository().GetAverageAccountPerPerson();
        }

        public DataSet GetDemography()
        {
            return new ClientRepository().GetDemography();
        }
    }
}

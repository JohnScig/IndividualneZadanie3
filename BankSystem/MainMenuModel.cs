using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public AutoCompleteStringCollection GetAllPersonalIDs()
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (string item in new ClientRepository().GetAllPersonalIDs())
            {
                autoCompleteStringCollection.Add(item);
            }
            return autoCompleteStringCollection;
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

        public DataSet GetTopAccounts()
        {
            return new AccountRepository().GetTopAccounts();
        }

        public DataSet GetAccountByMonth()
        {
            return new AccountRepository().GetAccountsByMonths();
        }
    }
}

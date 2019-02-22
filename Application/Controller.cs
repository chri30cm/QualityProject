using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Controller
    {
        public bool CheckCustomerID(int customerID)
        {
            CustomerRepo customerRepo = new CustomerRepo();
            if (customerRepo.GetCustomer(customerID) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            

        }
    }
}

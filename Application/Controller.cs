using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Controller
    {
        public void CheckCustomerID(int customerID)
        {
            CustomerRepo customerRepo = new CustomerRepo();
            customerRepo.GetCustomer(customerID);
        }
    }
}

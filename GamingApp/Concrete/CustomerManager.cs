using GamingApp.Abstract;
using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckCustomer(customer))
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " is added to the gaming platform as " + customer.NickName);
            }
            else
            {
                throw new Exception("Not a valid customer");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " is deleted from the gaming platform");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + ": your information has been updated");
        }
    }
}

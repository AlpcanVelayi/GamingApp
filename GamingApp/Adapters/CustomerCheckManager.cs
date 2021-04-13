using EDevletServiceReference;
using GamingApp.Abstract;
using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Adapters
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),Convert.ToInt32( customer.BirthDate)).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

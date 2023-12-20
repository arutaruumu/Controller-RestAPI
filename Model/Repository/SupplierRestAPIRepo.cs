using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CashierDist.Model.Entity;

namespace CashierDist.Model.Repository
{
    public class SupplierRestAPIRepo
    {
        public int Create(Supplier supplier)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/supplier";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(supplier);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Supplier supplier)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/supplier?search={supplier.Id_supplier}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.PUT);
            request.AddJsonBody(supplier);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Supplier supplier)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/supplier?search={supplier.Id_supplier}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddJsonBody(supplier);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }
        public List<Supplier> ReadAll()
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/supplier";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Supplier>>(request);

            return response.Data;
        }

        public List<Supplier> ReadByNama(string nama)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/supplier?search={nama}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Supplier>>(request);

            return response.Data;
        }
        public List<Supplier> ReadById(string id_supplier)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/supplier?search={id_supplier}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Supplier>>(request);

            return response.Data;

        }
    }
}
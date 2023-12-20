using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CashierDist.Model.Entity;

namespace CashierDist.Model.Repository
{
    public class AdminRestAPIRepo
    {
        public int Create(Admin admin)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/admin";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(admin);

            var response  = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Admin admin)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/admin?search={admin.Id_admin}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.PUT);
            request.AddJsonBody(admin);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Admin admin)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/admin?search={admin.Id_admin}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddJsonBody(admin);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }
        public List<Admin> ReadAll()
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/admin";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Admin>>(request);

            return response.Data;
        }
        public List<Admin> ReadByNama(string nama)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/admin?search={nama}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Admin>>(request);

            return response.Data;
        }
        public List<Admin> ReadById(int id_admin)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/admin?search={id_admin}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Admin>>(request);

            return response.Data;

        }
    }
}

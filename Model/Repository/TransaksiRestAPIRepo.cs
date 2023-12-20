using CashierDist.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CashierDist.Model.Entity;

namespace CashierDist.Model.Repository
{
    internal class TransaksiRestAPIRepo
    {
        public int Create(Transaksi transaksi)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/transaksi";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(transaksi);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Admin admin)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/transaksi?search={admin.Id_admin}";

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
            string endpoint = $"api/v1/transaksi?search={admin.Id_admin}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddJsonBody(admin);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }
        public List<Transaksi> ReadAll()
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/transaksi";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Transaksi>>(request);

            return response.Data;
        }
        public List<Transaksi> ReadByNama(string nama)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/transaksi?search={nama}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Transaksi>>(request);

            return response.Data;
        }
        public List<Transaksi> ReadById(string id_transaksi)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/transaksi?search={id_transaksi}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Transaksi>>(request);

            return response.Data;

        }
    }
}

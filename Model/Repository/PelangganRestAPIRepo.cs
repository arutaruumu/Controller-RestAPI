using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CashierDist.Model.Entity;

namespace CashierDist.Model.Repository
{
    public class PelangganRestAPIRepo
    {
        public int Create(Pelanggan pelanggan)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/pelanggan";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(pelanggan);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Pelanggan pelanggan)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/pelanggan?search={pelanggan.Id_pelanggan}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.PUT);
            request.AddJsonBody(pelanggan);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Pelanggan pelanggan)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/pelanggan?search={pelanggan.Id_pelanggan}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddJsonBody(pelanggan);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }
        public List<Pelanggan> ReadAll()
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/pelanggan";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Pelanggan>>(request);

            return response.Data;
        }
        public List<Pelanggan> ReadByNama(string nama)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/pelanggan?search={nama}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Pelanggan>>(request);

            return response.Data;
        }
        public List<Pelanggan> ReadById(string id_pelanggan)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/pelanggan?search={id_pelanggan}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Pelanggan>>(request);

            return response.Data;
        }
    }
}

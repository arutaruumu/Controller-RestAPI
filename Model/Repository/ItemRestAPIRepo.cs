using CashierDist.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierDist.Model.Repository
{
    public class ItemRestAPIRepo
    {
        public int Create(Item item)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = "api/v1/barang";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(item);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Item item)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/barang?search={item.Id_item}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.PUT);
            request.AddJsonBody(item);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Item item)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/barang?search={item.Id_item}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddJsonBody(item);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }
        public List<Item> ReadAll()
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/barang";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }
        public List<Item> ReadByNama(string nama)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/barang?search={nama}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }
        public List<Item> ReadById(string id_item)
        {
            string baseUrl = "https://ip_ku/";
            string endpoint = $"api/v1/barang?search={id_item}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Item>>(request);

            return response.Data;

        }
    }
}

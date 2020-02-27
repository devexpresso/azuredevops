using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web
{
    public class GoogleApiHelper
    {
        public VolumeCollection GetBooks()
        {
            var client = new RestClient("https://www.googleapis.com/books/v1/volumes?q=search+terms");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<VolumeCollection>(response.Content);
            return result;
        }
    }
}

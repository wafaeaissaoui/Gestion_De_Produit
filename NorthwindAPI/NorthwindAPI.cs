using Flurl;
using Flurl.Http;
using Gestion_de_Produit.models;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;

namespace Gestion_de_Produit.Utils
{
    public class NorthwindAPI
    {
        public static async Task<IEnumerable<T>?> Downloading<T> ()
        {
            var AppUrl = "https://services.odata.org/Experimental/Northwind/Northwind.svc";
            var results = await AppUrl
                .AppendPathSegment("Products")
                .SetQueryParam("", "", true)
                .GetAsync()
                ;
            var reslt=  results.GetStringAsync();
            JObject root = JObject.Parse(reslt.Result);
            JArray values = (JArray)root["value"];
            IEnumerable<T> listProduits = JsonConvert.DeserializeObject<IEnumerable<T>>(values.ToString());
            return listProduits;


        }
        public static async Task<T?> GetProduitById<T>(int Id)
        {
            var AppUrl = "https://services.odata.org/Experimental/Northwind/Northwind.svc";
            var results = AppUrl
                .AppendPathSegment($"Products({Id})")
                .GetAsync()
                .Result;
            //Console.WriteLine(results);
            var reslt = await results.GetJsonAsync<T>();
            //Console.WriteLine(reslt);
            return (T?)reslt;


        }

    }
}

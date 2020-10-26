using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OnlineShoppingWebApp.Common
{
    public class CreateHTTPClient
    {
        private readonly HttpClient client;
        private readonly IConfiguration config;

        public CreateHTTPClient()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri(this.config.GetSection("uri").Value);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

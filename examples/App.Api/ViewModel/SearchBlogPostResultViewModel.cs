using System;
using Newtonsoft.Json;

namespace App.Api.ViewModel
{
    public class SearchBlogPostResultViewModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("creation_date")]
        public DateTime CreationDate { get; set; }

    }
}
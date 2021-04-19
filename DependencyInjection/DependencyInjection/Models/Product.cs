using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Product
    {
        /*[Required]
        [MaxLength(200)]*/
        public string Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Maker { get; set; }

        [Required]
        [MaxLength(250)]
        [JsonPropertyName("img")]
        public string Image { get; set; }

        [Required]
        [MaxLength(250)]
        public string Url { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }


        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

        
    }
}

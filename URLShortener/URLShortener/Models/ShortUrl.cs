using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using UrlShortener.Models;

namespace URLShortener.Models
{
    public class ShortUrl
    {
        public int Id { get; set; }
        [Required]
        public string OriginalUrl { get; set; }
        [Required]
        public string ShortCode { get; set; }
        public string CreatedById   { get; set; }

        public AppUser CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

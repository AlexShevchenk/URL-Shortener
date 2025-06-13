using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using UrlShortener.Models;

namespace URLShortener.Models
{
    public class AboutContent
    {
        public int Id { get; set; }
        public string Desciption { get; set; }
        public string LastEditedById { get; set; }
        public AppUser LastEditedBy { get; set; }

        public DateTime LastEditedDate { get; set; }

    }
}

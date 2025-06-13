﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public class AppUser : IdentityUser
    {
        public string Role { get; set; }
    }

}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASU.Web.Models
{
    public class DeclarantView
    {
        public string Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        
        public string Address { get; set; }
        public string Phone { get; set; }
        public string IIN { get; set; }
    }
}
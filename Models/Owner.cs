﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvenManager.Models
{
    public class Owner
    {
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
    }
}

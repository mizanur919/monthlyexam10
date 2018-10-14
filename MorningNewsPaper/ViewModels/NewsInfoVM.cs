﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorningNewsPaper.ViewModels
{
    public class NewsInfoVM
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string FacebookUrl { get; set; }
        public string InstaUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string TwitterUrl { get; set; }
    }
}
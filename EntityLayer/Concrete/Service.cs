﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required(ErrorMessage ="Title hissesini doldurun")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
    }
}
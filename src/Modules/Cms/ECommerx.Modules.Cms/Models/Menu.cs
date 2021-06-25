﻿using ECommex.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerx.Modules.Cms.Models
{
    public class Menu : EntityBase
    {
        public Menu()
        {

        }
        public Menu(long id)
        {
            Id = id;
        }


        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }
        
        public bool IsPublished { get; set; }
    }
}

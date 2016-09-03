﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAlfredo.Models
{
    public class SaleLine
    {
        [Key]
        public int IdSaleLine { get; set; }

        public int Discount { get; set; }

        public float SaleQuantity { get; set; }

        public float LineTotal { get; set; }

        public int IdSale { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class Product
    {

        [Key]
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Descripción")]
        public string ProductDescription { get; set; }

        [Display(Name = "Costo")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Cost { get; set; }

        [Display(Name = "P Mayorista")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal WholeSalePrice { get; set; }

        [Display(Name = "P Minorista")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PublicPrice { get; set; }

        [Display(Name = "Última Actualización")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime UploadDate { get; set; }
        
        public float Stock { get; set; }

        [Display(Name = "Stock mínimo")]
        public float Minimum { get; set; }

        public bool State { get; set; }

        public string Image { get; set; }

        public int idCategory { get; set; } //Clave Foránea de Category

        public virtual Category Category { get; set; }

        public virtual ICollection<PurchaseLine> PurchaseLines { get; set; }

        public virtual ICollection<SaleLine> SaleLines { get; set; }

        public virtual ICollection<ProductProvider> Providers { get; set; }



    }
}
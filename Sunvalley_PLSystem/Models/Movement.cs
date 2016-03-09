﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunvalley_PLSystem.Models
{
    public class Movement
    {
        [Key]
        public int movementID { get; set; }

        [Display(Name = "Create By")]
        public string createBy { get; set; }
        [Display(Name = "Tranzaction Date")]
        public DateTime transactionDate { get; set; }
        [Display(Name = "Code")]
        public string code { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Value")]
        public decimal value { get; set; }
        [Display(Name = "QTY")]
        public int qty { get; set; }
        [Display(Name = "Amount")]
        public decimal amount { get; set; }
        [Display(Name = "Balance")]
        public decimal balance { get; set; }

        public virtual House house { get; set; }
        public virtual RegisterViewModel uruario { get; set; }


    }
}
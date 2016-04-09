﻿    using System;
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
        [Display(Name = "Transaction Date")]
        [DataType(DataType.Date)]
        public DateTime transactionDate { get; set; }
        [Display(Name = "type of movement")]
        public string typeOfMovement { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Amount")]
        public decimal amount { get; set; }
        [Display(Name = "Balance")]
        public decimal balance { get; set; }

        //To one movement correspond one house
        public int houseID { get; set; }
        public virtual House house { get; set; }

        public int serviceID { get; set; }
        public virtual Services services { get;set;}

        //To one movement correspond one user
        public virtual String UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sunvalley_PLSystem.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        //Yo lo cree Rangel el joto
//***************************************************************************
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Create At")]
        public DateTime createAt { get; set; }

        [Display(Name = "Company")]
        public string company { get; set; }

        [Display(Name = "Adress1")]
        public string adress1 { get; set; }

        [Display(Name = "Adress2")]
        public string adress2 { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Postal Code")]
        public int postalCode { get; set; }

        [Display(Name = "Home Phone")]
        public string homePhone { get; set; }

        [Display(Name = "Business Phone")]
        public string businessPhone { get; set; }

        [Display(Name = "Business Fax")]
        public string businesFax { get; set; }

        [Display(Name = "Mobile Phone")]
        public string mobilePhone { get; set; }


        //***************************************************************************
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


       
        [Display(Name = "AddEmail#1")]
        public string Email1 { get; set; }

        
        [Display(Name = "AddEmail#2")]
        public string Email2 { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        public virtual ICollection<House> houses { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

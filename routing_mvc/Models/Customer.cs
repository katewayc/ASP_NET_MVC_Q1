﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace routing_mvc.Models
{
    public class Customer
    {
        [Required]
        [StringLength(20,MinimumLength =3,ErrorMessage ="at least 3 letters")]
        [Remote(action: "Verify", controller: "Customer")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$",ErrorMessage ="phone format has to be 09xx-xxx-xxx")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="please enter Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
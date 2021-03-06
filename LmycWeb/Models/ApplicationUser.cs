﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LmycWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LmycWeb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Member Status")]
        public string MemberStatus { get; set; }
        [Display(Name = "Skipper Status")]
        public string SkipperStatus { get; set; } 
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [Display(Name = "Mobile Phone")]
        [Phone]
        public string MobilePhone { get; set; }
        [Display(Name = "Home Phone")]
        [Phone]
        public string HomePhone { get; set; }
        [Display(Name = "Work Phone")]
        [Phone]
        public string WorkPhone { get; set; }
        [Display(Name = "Sailing Qualifications")]
        public string SailingQualifications { get; set; }
        public string Skills { get; set; }
        [Display(Name = "Sailing Experience")]
        public string SailingExperience { get; set; }
        public int Credits { get; set; }

        [Required]
        public string EmergencyContactId { get; set; }
        public EmergencyContact EmergencyContacts { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Report> Reports { get; set; }
        [NotMapped]
        public int TotalHours { get; set; }

    }
}

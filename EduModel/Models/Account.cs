﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EduModel.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? GroupId { get; set; }
        public int? PersonalId { get; set; }  
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }


        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public PersonalRole PersonalRoles { get; set; }
    }
}
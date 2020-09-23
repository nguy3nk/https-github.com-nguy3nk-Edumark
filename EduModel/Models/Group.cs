﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EduModel.Models
{
    [Table("Group")]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsAdmin { get; set; }
        public bool Status { get; set; }

        public ICollection<Account> Users { get; set; }
        public ICollection<GroupRole> GroupRoles { get; set; }
    }

}
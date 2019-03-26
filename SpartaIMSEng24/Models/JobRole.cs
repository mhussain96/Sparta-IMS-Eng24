﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SpartaIMSEng24.Models
{
    public class JobRole
    {
        [Key]
        [Display(Name = "Role ID")]
        public int JobRoleID { get; set; }
        [Display(Name = "Role Name")]
        public string JobRoleName { get; set; }

        //Adding foreign key constraints
        public List<SpartanUser> SpartanUsers { get; set; }
    }   
}

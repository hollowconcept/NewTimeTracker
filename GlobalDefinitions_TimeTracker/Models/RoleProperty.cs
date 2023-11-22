﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDefinitions_TimeTracker.Models
{
    public class RoleProperty
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Maximal 100 Zeichen sind erlaubt !")]
        public string RoleName { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
    }
}

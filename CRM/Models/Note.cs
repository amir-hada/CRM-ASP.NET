﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Note
    {
        public int Id { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Please Enter Note's Content")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please Enter Id Of Business")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Please Enter Id Of User")]
        public int UserId { get; set; }

        public int IsDeleted { get; set; }
    }
}

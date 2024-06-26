﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.Entity
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; } 
     
        public string SenderName { get; set; } = "";
        public string Subject { get; set; } = "";

        public string SenderEmail { get; set; } = "";
        public string Body { get; set; } = "";
    }
}

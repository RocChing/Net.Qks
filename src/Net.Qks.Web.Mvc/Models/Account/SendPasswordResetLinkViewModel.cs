﻿using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
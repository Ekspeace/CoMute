﻿using System.ComponentModel.DataAnnotations;

namespace CoMute.Models.Dto
{
    public sealed class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

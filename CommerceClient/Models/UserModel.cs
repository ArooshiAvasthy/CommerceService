﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommerceClient.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerySys_DAL.Models
{
    public class SignUpModel
    {
        public string AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminRole { get; set; }
        public string AdminPassword { get; set; }
        public byte[] AdminPhoto { get; set; }

    }
}
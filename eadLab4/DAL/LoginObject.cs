﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eadLab4.DAL
{
    public class LoginObject
    {
        public int User { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public Guid UniqueID { get; set; }
        public LoginObject()
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrudOprationApp.Models
{
    public class tbl_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
    }
}
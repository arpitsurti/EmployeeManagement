﻿using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeEditViewModel
    {
        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}

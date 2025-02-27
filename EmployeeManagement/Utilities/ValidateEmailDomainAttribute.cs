﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class ValidateEmailDomainAttribute : ValidationAttribute
    {
        private readonly string allowedDomain;

        public ValidateEmailDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }
        public override bool IsValid(object value)
        {
            return value.ToString().Split('@')[1].ToUpper() == allowedDomain.ToUpper();
        }
    }
}

using FluentValidation;
using RbPrinters.Api.Contracts.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Validation
{
    public class BranchRequestValidator : AbstractValidator<BranchRequest>
    {
        public BranchRequestValidator()
        {
            
        }
    }
}

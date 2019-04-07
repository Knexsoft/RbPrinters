using System;
using System.Linq;
using FluentValidation;
using RbPrinters.Api.Common.Constants;
using RbPrinters.Api.Contracts.Models.Request;

namespace RbPrinters.Api.Contracts.Validation
{
    public class LoginValidator: AbstractValidator<Login>
    {
        public LoginValidator()
        {
            RuleFor(r => r.UserName)
                .NotEmpty().WithMessage(ValidationMessage.USER_NAME_NOT_NULL)
                .Must(BeMobileNumber).WithMessage(ValidationMessage.INVALID_MOBILE_NUMBER);
            RuleFor(r => r.Password).NotEmpty().WithMessage(ValidationMessage.PASSWORD_NOT_NULL);
        }

        private bool BeMobileNumber(string number)
        {
            bool isNum = double.TryParse(number, out double result);
            return isNum ? number.Length ==10 ? true : false : false;
        }
    }
}

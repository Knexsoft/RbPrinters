using RbPrinters.Api.Contracts.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RbPrinters.Api.Contracts.Models.Request
{
    public class Login : IValidatableObject
    {
        /// <summary>
        /// Gets or sets the primary mobile of user
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// gets or sets password of user
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Validate login requtest model with fulent validator
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new LoginValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}

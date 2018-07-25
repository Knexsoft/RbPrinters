using RbPrinters.Api.Contracts.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RbPrinters.Api.Contracts.Models.Request
{
    public class BranchRequest : IValidatableObject
    {
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string MobileAlt { get; set; }
        public string Phone { get; set; }
        public string EmailID { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new BranchRequestValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}

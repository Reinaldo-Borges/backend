using System;
using System.ComponentModel.DataAnnotations;

namespace DynamicSchool.API.Model.Request
{
    public class StudentRequest
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field length must be between {2} and {1} characters")]
        public string Name { get;  set; }      
        [EmailAddress(ErrorMessage = "The field {0} has incorrect value")]
        public string Email { get;  set; }
        [Required(ErrorMessage = "The field {0} is required")]
        public string CellPhone { get;  set; }
        [Required(ErrorMessage = "The field {0} is required")]
        public DateTime BirthDay { get;  set; }
        [Required(ErrorMessage = "The field {0} is required")]     
        public Guid ClientId { get;  set; }
    }
}

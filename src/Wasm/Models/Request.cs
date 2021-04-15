using System;
using System.ComponentModel.DataAnnotations;

namespace IR.DeviceRequestApp.Wasm
{
    public class Request
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime? PreferredDeliveryDate { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Select a device")]
        public int DeviceId { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Your consent is required")]
        public bool GdprApproval { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WizardMvc.Domain.Entities
{
    [Serializable]
    public class RegistrationData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Hobbies { get; set; }
    }
}
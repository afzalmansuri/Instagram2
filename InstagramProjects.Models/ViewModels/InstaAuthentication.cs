using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace InstagramProjects.Models.ViewModels
{
    class InstaAuthentication
    {
       
        public string InstaUserEmail { get; set; }
        public string InstaUserName { get; set; }

        public string InstaPhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

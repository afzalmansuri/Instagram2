using System.ComponentModel.DataAnnotations;

namespace InstagramProjects.Models.ViewModels
{

    public partial class AuthenticationModel
    {
        [Required]
        public string InstaUserName { get; set; }

        [Required]
        public string InstaUserPassword { get; set; }
    }
}


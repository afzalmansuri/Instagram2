using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InstagramProjects.Models.ViewModels
{
    public partial class InstaUser1
    {
        [NotMapped]
        public string token { get; set; }
    }
}

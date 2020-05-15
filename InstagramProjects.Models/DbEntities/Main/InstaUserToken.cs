using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InstagramProjects.Models.DbEntities.Main
{
    public partial class InstaUser
    {
        [NotMapped]
        public string token { get; set; }
    }
}

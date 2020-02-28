using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vInstaUsers",Schema="dbo")]
    public partial class vInstaUser
    {
		#region InstaUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }


        public string InstaUserName { get; set; }


        public string InstaUserEmail { get; set; }


        public string InstaUserMobileNumber { get; set; }


        public string InstaUserPassword { get; set; }


        public vInstaUser()
        {
        }
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vUserProfile",Schema="dbo")]
    public partial class vUserProfile
    {
		#region InstaUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }


        public string InstaUserName { get; set; }


        public string InstaUserFullName { get; set; }


        public string UserBio { get; set; }


        public string UserWebsite { get; set; }


        public string UserImage { get; set; }


        public vUserProfile()
        {
        }
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vFollowerPost",Schema="dbo")]
    public partial class vFollowerPost
    {
		#region FollowTo Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FollowTo Annotations

        public int FollowTo { get; set; }


        public int FollowBy { get; set; }


        public string PostContent { get; set; }


        public string InstaUserName { get; set; }


        public System.DateTimeOffset PostDateTime { get; set; }


        public int PostId { get; set; }


        public vFollowerPost()
        {
        }
	}
}
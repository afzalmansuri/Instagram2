using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vFollowers",Schema="dbo")]
    public partial class vFollower
    {

        public string Followers { get; set; }

		#region FollowTo Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FollowTo Annotations

        public int FollowTo { get; set; }


        public vFollower()
        {
        }
	}
}
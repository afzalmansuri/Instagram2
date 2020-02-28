using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("VLikes",Schema="dbo")]
    public partial class VLike
    {
		#region LikedById Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LikedById Annotations

        public int LikedById { get; set; }


        public string InstaUserName { get; set; }


        public string PostContent { get; set; }


        public int InstaUserId { get; set; }


        public VLike()
        {
        }
	}
}
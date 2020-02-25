using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.Models.Enums.Main;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("PostShares",Schema="dbo")]
    public partial class PostShare
    {
		#region PostShareId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostShareId Annotations

        public int PostShareId { get; set; }

		#region ShareBy Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","ShareBy")]
		#endregion ShareBy Annotations

        public int ShareBy { get; set; }

		#region ShareTo Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","ShareTo")]
		#endregion ShareTo Annotations

        public int ShareTo { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region ShareDateTime Annotations

        [Required]
		#endregion ShareDateTime Annotations

        public System.DateTimeOffset ShareDateTime { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Post.PostShares))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(ShareBy))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.PostShares))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region InstaUser1 Annotations

        [ForeignKey(nameof(ShareTo))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.PostShares1))]
		#endregion InstaUser1 Annotations

        public virtual InstaUser InstaUser1 { get; set; }


        public PostShare()
        {
        }
	}
}
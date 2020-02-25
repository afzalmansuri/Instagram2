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
    [Table("PostComments",Schema="dbo")]
    public partial class PostComment
    {
		#region PostCommentId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostCommentId Annotations

        public int PostCommentId { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region Comment Annotations

        [Required]
		#endregion Comment Annotations

        public string Comment { get; set; }

		#region CommentUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","CommentUserId")]
		#endregion CommentUserId Annotations

        public int CommentUserId { get; set; }

		#region CommentDateTime Annotations

        [Required]
		#endregion CommentDateTime Annotations

        public System.DateTimeOffset CommentDateTime { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Post.PostComments))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(CommentUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.PostComments))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }


        public PostComment()
        {
        }
	}
}
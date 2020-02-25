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
    [Table("StoryComments",Schema="dbo")]
    public partial class StoryComment
    {
		#region StoryCommentId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StoryCommentId Annotations

        public int StoryCommentId { get; set; }

		#region Comment Annotations

        [Required]
        [MaxLength(50)]
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

		#region StoryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Stories","dbo","","StoryId")]
		#endregion StoryId Annotations

        public int StoryId { get; set; }

		#region Story Annotations

        [ForeignKey(nameof(StoryId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Story.StoryComments))]
		#endregion Story Annotations

        public virtual Story Story { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(CommentUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.StoryComments))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region ChatDetails Annotations

        [InverseProperty("StoryComment")]
		#endregion ChatDetails Annotations

        public virtual ICollection<ChatDetail> ChatDetails { get; set; }


        public StoryComment()
        {
			ChatDetails = new HashSet<ChatDetail>();
        }
	}
}
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
    [Table("Posts",Schema="dbo")]
    public partial class Post
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region InstaUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","InstaUserId")]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }

		#region PostType Annotations

        [Required]
		#endregion PostType Annotations

        public string PostType { get; set; }

		#region PostContent Annotations

        [Required]
		#endregion PostContent Annotations

        public string PostContent { get; set; }


        public string PostCaption { get; set; }

		#region PostDateTime Annotations

        [Required]
		#endregion PostDateTime Annotations

        public System.DateTimeOffset PostDateTime { get; set; }

		#region Status Annotations

        [Required]
        [MaxLength(10)]
		#endregion Status Annotations

        public string Status { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(InstaUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Posts))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region PostTags Annotations

        [InverseProperty("Post")]
		#endregion PostTags Annotations

        public virtual ICollection<PostTag> PostTags { get; set; }

		#region PostComments Annotations

        [InverseProperty("Post")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }

		#region PostLikes Annotations

        [InverseProperty("Post")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostShares Annotations

        [InverseProperty("Post")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }


        public Post()
        {
			PostTags = new HashSet<PostTag>();
			PostComments = new HashSet<PostComment>();
			PostLikes = new HashSet<PostLike>();
			PostShares = new HashSet<PostShare>();
        }
	}
}
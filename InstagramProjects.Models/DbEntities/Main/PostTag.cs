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
    [Table("PostTags",Schema="dbo")]
    public partial class PostTag
    {
		#region PostTagId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostTagId Annotations

        public int PostTagId { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region TaggedUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","TaggedUserId")]
		#endregion TaggedUserId Annotations

        public int TaggedUserId { get; set; }

		#region TagStatus Annotations

        [Required]
		#endregion TagStatus Annotations

        public bool TagStatus { get; set; }

		#region TagDateTime Annotations

        [Required]
		#endregion TagDateTime Annotations

        public System.DateTimeOffset TagDateTime { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Post.PostTags))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(TaggedUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.PostTags))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }


        public PostTag()
        {
        }
	}
}
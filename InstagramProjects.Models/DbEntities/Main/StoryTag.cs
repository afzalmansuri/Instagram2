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
    [Table("StoryTags",Schema="dbo")]
    public partial class StoryTag
    {
		#region StoryTagId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StoryTagId Annotations

        public int StoryTagId { get; set; }

		#region StoryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Stories","dbo","","StoryId")]
		#endregion StoryId Annotations

        public int StoryId { get; set; }

		#region TaggedUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","TaggedUserId")]
		#endregion TaggedUserId Annotations

        public int TaggedUserId { get; set; }

		#region TagDateTime Annotations

        [Required]
		#endregion TagDateTime Annotations

        public System.DateTimeOffset TagDateTime { get; set; }

		#region Story Annotations

        [ForeignKey(nameof(StoryId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Story.StoryTags))]
		#endregion Story Annotations

        public virtual Story Story { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(TaggedUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.StoryTags))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }


        public StoryTag()
        {
        }
	}
}
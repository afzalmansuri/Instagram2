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
    [Table("ViewStorys",Schema="dbo")]
    public partial class ViewStory
    {
		#region ViewStoryId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ViewStoryId Annotations

        public int ViewStoryId { get; set; }

		#region StoryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Stories","dbo","","StoryId")]
		#endregion StoryId Annotations

        public int StoryId { get; set; }

		#region ViewBy Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Followers","dbo","","ViewBy")]
		#endregion ViewBy Annotations

        public int ViewBy { get; set; }

		#region Follower Annotations

        [ForeignKey(nameof(ViewBy))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Follower.ViewStorys))]
		#endregion Follower Annotations

        public virtual Follower Follower { get; set; }

		#region Story Annotations

        [ForeignKey(nameof(StoryId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Story.ViewStorys))]
		#endregion Story Annotations

        public virtual Story Story { get; set; }


        public ViewStory()
        {
        }
	}
}
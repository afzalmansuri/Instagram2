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
    [Table("Stories",Schema="dbo")]
    public partial class Story
    {
		#region StoryId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StoryId Annotations

        public int StoryId { get; set; }

		#region InstaUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","InstaUserId")]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }

		#region StoryType Annotations

        [Required]
        [MaxLength(20)]
		#endregion StoryType Annotations

        public string StoryType { get; set; }

		#region StoryContent Annotations

        [Required]
		#endregion StoryContent Annotations

        public string StoryContent { get; set; }

		#region StoryDateTime Annotations

        [Required]
		#endregion StoryDateTime Annotations

        public System.DateTimeOffset StoryDateTime { get; set; }

		#region StoryStatus Annotations

        [Required]
		#endregion StoryStatus Annotations

        public bool StoryStatus { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(InstaUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Stories))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region StoryComments Annotations

        [InverseProperty("Story")]
		#endregion StoryComments Annotations

        public virtual ICollection<StoryComment> StoryComments { get; set; }

		#region StoryShares Annotations

        [InverseProperty("Story")]
		#endregion StoryShares Annotations

        public virtual ICollection<StoryShare> StoryShares { get; set; }

		#region StoryTags Annotations

        [InverseProperty("Story")]
		#endregion StoryTags Annotations

        public virtual ICollection<StoryTag> StoryTags { get; set; }

		#region ViewStorys Annotations

        [InverseProperty("Story")]
		#endregion ViewStorys Annotations

        public virtual ICollection<ViewStory> ViewStorys { get; set; }


        public Story()
        {
			StoryComments = new HashSet<StoryComment>();
			StoryShares = new HashSet<StoryShare>();
			StoryTags = new HashSet<StoryTag>();
			ViewStorys = new HashSet<ViewStory>();
        }
	}
}
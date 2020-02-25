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
    [Table("StoryShares",Schema="dbo")]
    public partial class StoryShare
    {
		#region StoryShareId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StoryShareId Annotations

        public int StoryShareId { get; set; }

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

		#region StoryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Stories","dbo","","StoryId")]
		#endregion StoryId Annotations

        public int StoryId { get; set; }

		#region ShareDateTime Annotations

        [Required]
		#endregion ShareDateTime Annotations

        public System.DateTimeOffset ShareDateTime { get; set; }

		#region UserPrivacyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("UserPrivacys","dbo","","UserPrivacyId")]
		#endregion UserPrivacyId Annotations

        public int UserPrivacyId { get; set; }

		#region Story Annotations

        [ForeignKey(nameof(StoryId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Story.StoryShares))]
		#endregion Story Annotations

        public virtual Story Story { get; set; }

		#region UserPrivacy Annotations

        [ForeignKey(nameof(UserPrivacyId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.UserPrivacy.StoryShares))]
		#endregion UserPrivacy Annotations

        public virtual UserPrivacy UserPrivacy { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(ShareBy))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.StoryShares))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region InstaUser1 Annotations

        [ForeignKey(nameof(ShareTo))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.StoryShares1))]
		#endregion InstaUser1 Annotations

        public virtual InstaUser InstaUser1 { get; set; }


        public StoryShare()
        {
        }
	}
}
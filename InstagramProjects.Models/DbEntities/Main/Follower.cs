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
    [Table("Followers",Schema="dbo")]
    public partial class Follower
    {
		#region FollowerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FollowerId Annotations

        public int FollowerId { get; set; }

		#region FollowBy Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","FollowBy")]
		#endregion FollowBy Annotations

        public int FollowBy { get; set; }

		#region FollowTo Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","FollowTo")]
		#endregion FollowTo Annotations

        public int FollowTo { get; set; }

		#region FollowDateTime Annotations

        [Required]
		#endregion FollowDateTime Annotations

        public System.DateTimeOffset FollowDateTime { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(FollowBy))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Followers))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region InstaUser1 Annotations

        [ForeignKey(nameof(FollowTo))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Followers1))]
		#endregion InstaUser1 Annotations

        public virtual InstaUser InstaUser1 { get; set; }

		#region ViewStorys Annotations

        [InverseProperty("Follower")]
		#endregion ViewStorys Annotations

        public virtual ICollection<ViewStory> ViewStorys { get; set; }


        public Follower()
        {
			ViewStorys = new HashSet<ViewStory>();
        }
	}
}
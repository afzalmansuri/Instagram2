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
    [Table("InstaUsers",Schema="dbo")]
    public partial class InstaUser
    {
		#region InstaUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }

		#region InstaUserName Annotations

        [Required]
        [MaxLength(50)]
		#endregion InstaUserName Annotations

        public string InstaUserName { get; set; }

		#region InstaUserFullName Annotations

        [MaxLength(50)]
		#endregion InstaUserFullName Annotations

        public string InstaUserFullName { get; set; }

		#region InstaUserEmail Annotations

        [MaxLength(50)]
		#endregion InstaUserEmail Annotations

        public string InstaUserEmail { get; set; }

		#region InstaUserMobileNumber Annotations

        [MaxLength(50)]
		#endregion InstaUserMobileNumber Annotations

        public string InstaUserMobileNumber { get; set; }

		#region InstaUserPassword Annotations

        [Required]
        [MaxLength(50)]
		#endregion InstaUserPassword Annotations

        public string InstaUserPassword { get; set; }

		#region InstaUserCountry Annotations

        [Required]
        [MaxLength(50)]
		#endregion InstaUserCountry Annotations

        public string InstaUserCountry { get; set; }

		#region UserPrivacyId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("UserPrivacys","dbo","","UserPrivacyId")]
		#endregion UserPrivacyId Annotations

        public int UserPrivacyId { get; set; }

		#region UserPrivacy Annotations

        [ForeignKey(nameof(UserPrivacyId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.UserPrivacy.InstaUsers))]
		#endregion UserPrivacy Annotations

        public virtual UserPrivacy UserPrivacy { get; set; }

		#region UserDetails Annotations

        [InverseProperty("InstaUser")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }

		#region Posts Annotations

        [InverseProperty("InstaUser")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region Chats Annotations

        [InverseProperty("InstaUser")]
		#endregion Chats Annotations

        public virtual ICollection<Chat> Chats { get; set; }

		#region Chats1 Annotations

        [InverseProperty("InstaUser1")]
		#endregion Chats1 Annotations

        public virtual ICollection<Chat> Chats1 { get; set; }

		#region Followers Annotations

        [InverseProperty("InstaUser")]
		#endregion Followers Annotations

        public virtual ICollection<Follower> Followers { get; set; }

		#region Followers1 Annotations

        [InverseProperty("InstaUser1")]
		#endregion Followers1 Annotations

        public virtual ICollection<Follower> Followers1 { get; set; }

		#region PostComments Annotations

        [InverseProperty("InstaUser")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }

		#region PostLikes Annotations

        [InverseProperty("InstaUser")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostShares Annotations

        [InverseProperty("InstaUser")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }

		#region PostShares1 Annotations

        [InverseProperty("InstaUser1")]
		#endregion PostShares1 Annotations

        public virtual ICollection<PostShare> PostShares1 { get; set; }

		#region Stories Annotations

        [InverseProperty("InstaUser")]
		#endregion Stories Annotations

        public virtual ICollection<Story> Stories { get; set; }

		#region StoryComments Annotations

        [InverseProperty("InstaUser")]
		#endregion StoryComments Annotations

        public virtual ICollection<StoryComment> StoryComments { get; set; }

		#region StoryShares Annotations

        [InverseProperty("InstaUser")]
		#endregion StoryShares Annotations

        public virtual ICollection<StoryShare> StoryShares { get; set; }

		#region StoryShares1 Annotations

        [InverseProperty("InstaUser1")]
		#endregion StoryShares1 Annotations

        public virtual ICollection<StoryShare> StoryShares1 { get; set; }

		#region StoryTags Annotations

        [InverseProperty("InstaUser")]
		#endregion StoryTags Annotations

        public virtual ICollection<StoryTag> StoryTags { get; set; }

		#region PostTags Annotations

        [InverseProperty("InstaUser")]
		#endregion PostTags Annotations

        public virtual ICollection<PostTag> PostTags { get; set; }


        public InstaUser()
        {
			UserDetails = new HashSet<UserDetail>();
			Posts = new HashSet<Post>();
			Chats = new HashSet<Chat>();
			Chats1 = new HashSet<Chat>();
			Followers = new HashSet<Follower>();
			Followers1 = new HashSet<Follower>();
			PostComments = new HashSet<PostComment>();
			PostLikes = new HashSet<PostLike>();
			PostShares = new HashSet<PostShare>();
			PostShares1 = new HashSet<PostShare>();
			Stories = new HashSet<Story>();
			StoryComments = new HashSet<StoryComment>();
			StoryShares = new HashSet<StoryShare>();
			StoryShares1 = new HashSet<StoryShare>();
			StoryTags = new HashSet<StoryTag>();
			PostTags = new HashSet<PostTag>();
        }
	}
}
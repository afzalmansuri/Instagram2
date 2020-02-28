using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vFollowerStories",Schema="dbo")]
    public partial class vFollowerStory
    {

        public string InstaUserName { get; set; }

		#region InstaUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }


        public string StoryContent { get; set; }


        public System.DateTimeOffset StoryDateTime { get; set; }


        public int FollowTo { get; set; }


        public int FollowBy { get; set; }


        public vFollowerStory()
        {
        }
	}
}
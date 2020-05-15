using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vComment",Schema="dbo")]
    public partial class vComment
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }


        public string Comment { get; set; }


        public System.DateTimeOffset CommentDateTime { get; set; }


        public string InstaUserFullName { get; set; }


        public int PostCommentId { get; set; }


        public vComment()
        {
        }
	}
}
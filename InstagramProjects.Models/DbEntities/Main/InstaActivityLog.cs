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
    [Table("InstaActivityLog",Schema="dbo")]
    public partial class InstaActivityLog
    {
		#region ActivityLogId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ActivityLogId Annotations

        public int ActivityLogId { get; set; }

		#region ActivityContent Annotations

        [Required]
		#endregion ActivityContent Annotations

        public string ActivityContent { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region ActivityDateTime Annotations

        [Required]
		#endregion ActivityDateTime Annotations

        public System.DateTimeOffset ActivityDateTime { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.Post.InstaActivityLog))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }


        public InstaActivityLog()
        {
        }
	}
}
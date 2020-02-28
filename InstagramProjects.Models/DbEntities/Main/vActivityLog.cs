using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vActivityLog",Schema="dbo")]
    public partial class vActivityLog
    {
		#region ActivityLogId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ActivityLogId Annotations

        public int ActivityLogId { get; set; }


        public string ActivityContent { get; set; }


        public int InstaUserId { get; set; }


        public int PostId { get; set; }


        public vActivityLog()
        {
        }
	}
}
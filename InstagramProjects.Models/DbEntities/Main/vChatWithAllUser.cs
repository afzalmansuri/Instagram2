using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vChatWithAllUsers",Schema="dbo")]
    public partial class vChatWithAllUser
    {
		#region SenderId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion SenderId Annotations

        public int SenderId { get; set; }


        public int RecieverId { get; set; }


        public string InstaUserName { get; set; }


        public vChatWithAllUser()
        {
        }
	}
}
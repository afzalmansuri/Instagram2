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
    [Table("Chats",Schema="dbo")]
    public partial class Chat
    {
		#region ChatId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ChatId Annotations

        public int ChatId { get; set; }

		#region SenderId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","SenderId")]
		#endregion SenderId Annotations

        public int SenderId { get; set; }

		#region RecieverId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","RecieverId")]
		#endregion RecieverId Annotations

        public int RecieverId { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(SenderId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Chats))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }

		#region InstaUser1 Annotations

        [ForeignKey(nameof(RecieverId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.Chats1))]
		#endregion InstaUser1 Annotations

        public virtual InstaUser InstaUser1 { get; set; }

		#region ChatDetails Annotations

        [InverseProperty("Chat")]
		#endregion ChatDetails Annotations

        public virtual ICollection<ChatDetail> ChatDetails { get; set; }


        public Chat()
        {
			ChatDetails = new HashSet<ChatDetail>();
        }
	}
}
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
    [Table("UserDetails",Schema="dbo")]
    public partial class UserDetail
    {
		#region UserDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserDetailId Annotations

        public int UserDetailId { get; set; }

		#region UserWebsite Annotations

        [MaxLength(50)]
		#endregion UserWebsite Annotations

        public string UserWebsite { get; set; }


        public string UserBio { get; set; }

		#region UserGender Annotations

        [MaxLength(10)]
		#endregion UserGender Annotations

        public string UserGender { get; set; }


        public string UserImage { get; set; }

		#region InstaUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("InstaUsers","dbo","","InstaUserId")]
		#endregion InstaUserId Annotations

        public int InstaUserId { get; set; }

		#region InstaUser Annotations

        [ForeignKey(nameof(InstaUserId))]
        [InverseProperty(nameof(InstagramProjects.Models.Main.InstaUser.UserDetails))]
		#endregion InstaUser Annotations

        public virtual InstaUser InstaUser { get; set; }


        public UserDetail()
        {
        }
	}
}
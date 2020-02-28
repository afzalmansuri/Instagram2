using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vFollowing",Schema="dbo")]
    public partial class vFollowing
    {

        public string Following { get; set; }

		#region FollowBy Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FollowBy Annotations

        public int FollowBy { get; set; }


        public vFollowing()
        {
        }
	}
}
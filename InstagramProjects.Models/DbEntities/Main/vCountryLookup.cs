using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using InstagramProjects.BoundedContext.SqlContext;
namespace InstagramProjects.Models.Main
{
    [Table("vCountryLookup",Schema="dbo")]
    public partial class vCountryLookup
    {

        public string InstaUserCountry { get; set; }


        public vCountryLookup()
        {
        }
	}
}
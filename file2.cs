using System;
using System.Collection.Generic;
using System.ComponentModel.DataAnnotation;
using System.ComponentModel.DataAnnotation.Schema;
using System.Linq;
using System.Web

namespace WebApplication1.Models
{
	Public class PostDetail
	{
		Public int PostID { get; set; }
		public	Nullable<int> PostWeight { get; set; }
		[Display(Name = "Post Name"]
		Public string PostName { get; set;}
		Public string Gender { get; set;}
		Public string Location { get; set;}

		Public string NativeID { get; set;}
	}
}
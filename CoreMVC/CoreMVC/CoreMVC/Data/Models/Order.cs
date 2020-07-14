using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Models
{
	public class Order
	{
		[BindNever]
		public int Id { get; set; }

		[Display(Name = "Enter name:")]
		[StringLength(25)]
		[Required(ErrorMessage = "incorrect data")]
		public string Name { get; set; }

		[Display(Name = "Enter surname:")]
		[StringLength(25)]
		[Required(ErrorMessage = "incorrect data")]
		public string SurName { get; set; }

		[Display(Name = "Enter adress:")]
		[StringLength(80)]
		[Required(ErrorMessage = "incorrect data")]
		public string Adress { get; set; }

		[Display(Name = "Enter email:")]
		[DataType(DataType.EmailAddress)]
		[StringLength(40)]
		[Required(ErrorMessage = "incorrect email")]
		public string EMail { get; set; }

		[Display(Name = "Enter phone number:")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(15)]
		[Required(ErrorMessage = "incorrect phone number")]
		public string Phone { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime OrderTime { get; set; }

		[BindNever]
		public List<OrderDetail> OrderDetails { get; set; }
	}
}

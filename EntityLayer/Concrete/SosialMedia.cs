using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class SosialMedia
	{
		[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		public string icon { get; set; }
		public string Url { get; set; }
	}
}

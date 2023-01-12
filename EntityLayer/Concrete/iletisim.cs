using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class iletisim
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage ="Ad hissesini doldurun")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Mail Alanini Doldurun")]
        public string Mail { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerASPProject.Models
{
    public class Producto
    {
      

    

        [Key]
        public int codigo { set; get; }
        public string  nombre { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
      //  public DateTime ultimacompra { set; get; }
        public int unidadeseninventario { set; get; }
       








    }
}

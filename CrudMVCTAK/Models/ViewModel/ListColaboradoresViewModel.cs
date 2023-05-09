using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMVCTAK.Models.ViewModel
{
    public class ListColaboradoresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? DateN { get; set; }
        public string EstadoCivil { get; set; }

        public string GradoAC { get; set; } 
        public string Direccion { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CrudMVCTAK.Models.ViewModel
{
    public class ColaboradoresViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Apellidos")]
        public string LastName { get; set; }
        [DisplayName("FechaNacimiento")]
        public DateTime DateN { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        [DisplayName("Ultimo Grado Cursado")]
        public string GradoAC { get; set; }
        [DisplayName("Direccion")]
        public string Direccion { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudMVCTAK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colaboradores
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateN { get; set; }
        public string EstadoCivil { get; set; }
        public string GradoAC { get; set; }
        public string Direccion { get; set; }
    }
}

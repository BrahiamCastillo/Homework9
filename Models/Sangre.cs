using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework9.Models
{
    public partial class Sangre
    {
        public Sangre()
        {
            Persona = new HashSet<Persona>();
        }

        public int Id { get; set; }
        public string TipoSangre { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}

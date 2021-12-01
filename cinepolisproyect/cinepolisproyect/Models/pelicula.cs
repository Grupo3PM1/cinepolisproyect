using System;
using System.Collections.Generic;
using System.Text;

namespace cinepolisproyect.Models
{
    public class pelicula
    {
        public string IdPelicula { get; set; }
        public string Pelicula { get; set; }
        public string Imagepeli { get; set; }
        public string Fechapeli { get; set; }
        public string IdHorario { get; set; }
        public string Horario { get; set; }
        public int IdCombo { get; set; }
        public int RefrescoExtra { get; set; }
    }
}

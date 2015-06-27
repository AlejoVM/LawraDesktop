using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
    public class OtS_Grados
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class OtS_Secciones
    {
        public string Name { get; set; }
        public char Character { get; set; }
    }

    public class OtS_Turnos
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class OtS_Salones
    {
        public int MaxCapacity { get; set; }
        public string Observation { get; set; }
    }

    public class OtS_Niveles
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class OtS_NivelesTurnos
    {

    }

}

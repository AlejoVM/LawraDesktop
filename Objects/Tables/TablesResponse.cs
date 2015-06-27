using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
    public class Distritos
    {
        public int Id { get; set; }
        public string Distrito { get; set; }
    }

    public class Provincias
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public List<Distritos> Distritos { get; set; }
    }

    public class Departamentos
    {
        public int Id { get; set; }
        public string Departamento { get; set; }
        public List<Provincias> Provincias { get; set; }
    }

    public class TipoDocumento
    {
        public int Id { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public int Length { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsExactLength { get; set; }
    }

    public class LastSchool
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
    }

    public class TypeParent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int type { get; set; }
    }
    
}

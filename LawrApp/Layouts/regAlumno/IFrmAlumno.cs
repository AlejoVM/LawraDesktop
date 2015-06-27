using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Objects.Processes;

namespace LawrApp.Layouts.regAlumno
{
    public interface IFrmAlumno
    {
        void AddDocuments( Document Odocument, string NameDoc );
        void AddParent( Parent OParent, string NameParent, string NameDocument );
    }
}

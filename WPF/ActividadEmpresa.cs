using System;
using System.Collections.Generic;

namespace WPF
{
    internal class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; internal set; }
        public string Descripcion { get; internal set; }

        internal List<ActividadEmpresa> LeerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
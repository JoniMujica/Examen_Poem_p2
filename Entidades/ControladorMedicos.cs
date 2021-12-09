using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControladorMedicos
    {
        private List<Medico> medicos;
        public ControladorMedicos()
        {
            medicos = new List<Medico>();
        }

        public List<Medico> Medicos
        {
            get 
            {
                return medicos;
            }
            set
            { 
                medicos = value; 
            } 
        }

        public override bool Equals(object obj)
        {
            foreach (Medico medico in this.medicos)
            {
                if (medico.Dni == ((Medico)obj).Dni)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (medicos).GetHashCode();
        }

        public static bool operator +(ControladorMedicos cm, Medico m)
        {
            if (!cm.Equals(m))
            {
                cm.medicos.Add(m);
                return true;
            }
            return false;
        }
        public static bool operator -(ControladorMedicos cm,Medico m)
        {
            return cm.medicos.Remove(m) ? true : false;
        }
    }
}

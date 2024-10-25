using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Alojamentos
    {

        #region ATRIBUTOS

        Alojamento[] alojamentos;
        int tot = 0;

        #endregion

        #region CONSTRUTORES

        public Alojamentos(int n)
        {
            alojamentos = new Alojamento[n];
        }

        #endregion

        #region METODOS

        public bool RegistarAlojamentos(Alojamento a)
        {
            if (tot < alojamentos.Length)
            {
                alojamentos[tot++] = a;
                return true;
            }

            return false;
        }

        public Alojamento PequisarAlojamento(int numero)
        {
            foreach (Alojamento alojamento in alojamentos)
            {
                if (alojamento.Numero == numero)
                {
                    return alojamento;
                }
            }
            return null;
        }

        public Alojamento[] AmostrarAlojamentos()
        {
            Alojamento[] totalAlojamentos = new Alojamento[tot];

            for (int i = 0; i < tot; i++)
            {
                totalAlojamentos[i] = alojamentos[i];
            }

            return totalAlojamentos;
        }

        #endregion
    }
}

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

        const int MAXALOJ = 20;
        static Alojamento[] alojamentos;
        static int totAloj = 0;

        #endregion

        #region CONSTRUTORES

        static Alojamentos()
        {
            alojamentos = new Alojamento[MAXALOJ];
            totAloj = 0;
        }

        #endregion

        #region METODOS

        public static bool RegistarAlojamentos(Alojamento a)
        {
            if (totAloj < MAXALOJ)
            {
                alojamentos[totAloj++] = a;
                return true;
            }

            return false;
        }


        public static Alojamento PequisarAlojamento(int numero)
        {
            foreach (Alojamento alojamento in alojamentos)
            {
                if ( alojamento.Numero == numero)
                {
                    return alojamento;
                }
            }
            return null;
        }

        public static Alojamento[] AmostrarAlojamentos()
        {
            Alojamento[] totalAlojamentos = new Alojamento[totAloj];

            for (int i = 0; i < totAloj; i++)
            {
                totalAlojamentos[i] = alojamentos[i];
            }

            return totalAlojamentos;
        }

        #endregion
    }
}

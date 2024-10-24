using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Reservas
    {
        #region ATRIBUTOS

        Reserva[] reservas;
        int tot = 0;

        #endregion

        #region CONSTRURORES

        public Reservas(int n)
        {
            reservas = new Reserva[n];
        }

        #endregion


        #region METODOS

        public bool RegistarReservas(Reserva r)
        {
            if (tot < reservas.Length)
            {
                reservas[tot++] = r;
                return true;
            }

            return false;
        }

        public Reserva PequisarReserva(int id)
        {
            foreach (Reserva reserva in reservas)
            {
                if (reserva.Id == id)
                {
                    return reserva;
                }
            }
            return null;
        }

        public Reserva AmostrarReservas()
        {
            for (int i = 0; i < reservas.Length; i++)
            {
                return reservas[i];
            }
            return null;
        }

        #endregion

    }
}

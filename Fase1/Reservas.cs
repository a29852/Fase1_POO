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

        const int MAXRES = 20;
        static Reserva[] reservas;
        static int totRes = 0;

        #endregion

        #region CONSTRURORES

        static Reservas()
        {
            reservas = new Reserva[MAXRES];
            totRes = 0;
        }

        #endregion


        #region METODOS

        public static bool CancelarReserva(Reserva r)
        {
            foreach (Reserva reserva in reservas)
            {
                if (reserva.Id == r.Id)   //verifica se a reserva a cancelar existe
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ModificarReserva(Reserva r, Alojamento a)
        {
            foreach (Reserva reserva in reservas)
            {
                if (reserva.Id == r.Id)   //verifica se a reserva existe
                {
                    reserva.Alojamento.Disponivel = true;
                    reserva.Alojamento = a;
                    a.Disponivel = false;
                    return true;
                }
            }
            return false;
        }

        public static bool RegistarReservas(Reserva r)
        {
            if (totRes < reservas.Length)
            {
                reservas[totRes++] = r;
                return true;
            }

            return false;
        }

        public static Reserva PequisarReserva(int id)
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

        public static Reserva[] AmostrarReservas()
        {
            Reserva[] totalReservas = new Reserva[totRes];

            for (int i = 0; i < totRes; i++)
            {
                totalReservas[i] = reservas[i];
            }

            return totalReservas;
        }

        #endregion

    }
}

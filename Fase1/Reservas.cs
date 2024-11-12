/**
 * Gustavo Pereira
 * a29852@alunos.ipca.pt
 */


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

        /// <summary>
        /// Atributos da classe Reserva
        /// </summary>

        const int MAXRES = 20;
        static Reserva[] reservas;
        static int totRes = 0;

        #endregion

        #region CONSTRURORES

        /// <summary>
        /// Construtor que serve para criar um array de Reservas
        /// </summary>

        static Reservas()
        {
            reservas = new Reserva[MAXRES];
            totRes = 0;
        }

        #endregion


        #region METODOS
    
        /// <summary>
        /// Metodo que serve para modificar uma reserva já existente
        /// </summary>
        /// <param name="r">A função recebe por parametro a reserva que vai ser modificada</param>
        /// <param name="a">A função receve por parametro o alojamento que vai ser alterado na reserva</param>
        /// <returns></returns>

        public static bool ModificarReserva(Reserva r, Alojamento a)
        {
            if (a.Disponivel == true)
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
            }
            return false;

        }

        /// <summary>
        /// A função regista uma nova reserva caso exista disponibilidade no array
        /// </summary>
        /// <param name="r">A função recebe um objeto "Reserva" como parametro</param>
        /// <returns></returns>

        public static bool RegistarReservas(Reserva r)
        {
            if (totRes < reservas.Length)
            {
                reservas[totRes++] = r;
                return true;
            }

            return false;
        }

        /// <summary>
        ///  A função procura um objeto "Reserva" e retorna se o encontrar
        /// </summary>
        /// <param name="id">O parametro é um numero inteiro que representa a identificação da reserva que vamos procurar</param>
        /// <returns></returns>

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

        /// <summary>
        /// A função cria um novo array para poder retornar as reservas que existem
        /// </summary>
        /// <returns></returns>

        public static Reserva[] AmostrarReservas()
        {
            Reserva[] totalReservas = new Reserva[totRes];

            for (int i = 0; i < totRes; i++)
            {
                totalReservas[i] = reservas[i];
            }

            return totalReservas;
        }

        /// <summary>
        /// A função verifica a chegado do cleinte
        /// </summary>
        /// <param name="id">O parametro identifca a reserva que vai ser feita o CheckIn</param>
        /// <returns></returns>

        public static bool FazerCheckIn(int id)
        {
            Reserva reserva = PequisarReserva(id);

            if(reserva != null)
            {
                reserva.CheckIn = true;
                return true;
            }
            return false;
        }

        #endregion

    }
}

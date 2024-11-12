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
    internal class Reserva
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Reserva
        /// </summary>

        int id = 0;
        Cliente cliente;
        Alojamento alojamento;
        DateTime dataInicio;
        DateTime dataFim;
        bool checkIn;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Utilizamos o construtor para poder inicializar um novo objeto da classe
        /// </summary>
        /// <param name="id">Identifica a reserva</param>
        /// <param name="c">identifica o cliente que fez a reserva</param>
        /// <param name="a">identifica o alojamento referente a reserva</param>
        /// <param name="dataFim">identifica a data de fim da reserva</param>

        public Reserva(int id, Cliente c, Alojamento a, DateTime dataFim)
        {
            this.id = id;
            this.cliente = c;
            this.alojamento = a;
            this.alojamento.Disponivel = false;
            dataInicio = DateTime.Now;
            this.dataFim = dataFim;
            this.checkIn = false;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public Alojamento Alojamento
        {
            get
            {
                return alojamento;
            }
            set
            {
                alojamento = value;
            }
        }

        public DateTime DataInicio
        {
            get
            {
                return dataInicio;
            }
            set
            {
                dataInicio = value;
            }
        }

        public DateTime DataFim
        {
            get
            {
                return dataFim;
            }
            set
            {
                dataFim = value;
            }
        }

        public bool CheckIn
        {
            get
            {
                return checkIn;
            }
            set
            {
                checkIn = value;
            }
        }

        #endregion

    }
}

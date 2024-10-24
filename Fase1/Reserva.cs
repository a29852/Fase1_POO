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

        int id = 0;
        Cliente cliente;
        Alojamento alojamento;
        DateTime dataInicio;
        DateTime dataFim;

        #endregion

        #region CONSTRUTORES

        public Reserva(int id, Cliente c, Alojamento a, DateTime dataFim)
        {
            this.id = id;
            this.cliente = c;
            this.alojamento = a;
            dataInicio = DateTime.Now;
            this.dataFim = dataFim;
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

        #endregion

    }
}

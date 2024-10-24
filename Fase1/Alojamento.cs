using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Alojamento
    {
        #region ATRIBUTOS
        int numero;
        string tipo;
        string localizacao;
        double precoNoite;
        bool disponivel;
        #endregion


        #region CONSTRUTOR

        public Alojamento(int numero, string tipo, string localizacao, double precoNoite, bool disponivel)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.localizacao = localizacao;
            this.precoNoite = precoNoite;
            this.disponivel = disponivel;
        }

        #endregion


        #region PROPRIEDADES
        
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public string Localizacao
        {
            get
            {
                return localizacao;
            }
            set
            {
                localizacao = value;
            }
        }

        public double PrecoNoite
        {
            get
            {
                return precoNoite;
            }
            set
            {
                precoNoite = value;
            }
        }

        public bool Disponivel
        {
            get
            {
                return disponivel;
            }
            set
            {
                disponivel = value;
            }
        }

        #endregion

    }
}

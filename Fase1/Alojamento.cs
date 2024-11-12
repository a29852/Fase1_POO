/**
 * Gustavo Pereira
 * a29852@alunos.ipca.pt
 */



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

        /// <summary>
        /// Atributos da classe Alojamento
        /// </summary>

        int numero;
        string tipo;
        string localizacao;
        double precoNoite;
        bool disponivel;
        #endregion


        #region CONSTRUTOR

        /// <summary>
        /// Utilizamos o construtor para inicializar um novo objeto da classe
        /// </summary>
        /// <param name="numero">referente ao numero do alojamento</param>
        /// <param name="tipo">referente ao tipo de alojamento (casa, apartamento)</param>
        /// <param name="localizacao">referente á localização do apartamento</param>
        /// <param name="precoNoite">referente ao preço por noite do apartamento</param>
        /// <param name="disponivel">referente á disponivilidade, se o apartamento já está reservado ou não</param>
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

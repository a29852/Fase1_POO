using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Cliente
    {
        #region ATRIBUTOS
        int nif;
        string nome;
        int contacto;
        int idade;
        #endregion


        #region CONSTRUTORES
        public Cliente(int nif, string nome, int contacto, int idade)
        {
            this.nif = nif;
            this.nome = nome;
            this.contacto = contacto;
            this.idade = idade;
        }

        #endregion

        #region PROPRIEDADES
        
        public int Nif
        {
            get 
            {
            return nif;
            }
            set
            {
                nif = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Contacto
        {
            get
            {
                return contacto;
            }
            set
            {
                contacto = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        #endregion

    }
}

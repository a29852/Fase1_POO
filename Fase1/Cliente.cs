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
    internal class Cliente : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Cliente
        /// </summary>

        int id;
        string nome;
        int contacto;

        #endregion


        #region CONSTRUTORES

        /// <summary>
        /// Construtor para criar um novo Cliente
        /// </summary>
        /// <param name="id">Identificação do cliente</param>
        /// <param name="nome">Nome do cliente</param>
        /// <param name="contacto">Contacto do cliente</param>
        /// <param name="idade">Idade do cliente</param>
        /// <param name="sexo">Sexo do cliente</param>
        public Cliente(int id, string nome, int contacto, int idade, string sexo)
        {
            this.id = id;
            this.nome = nome;
            this.contacto = contacto;
            Idade = idade;
            Sexo = sexo;
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

  

        #endregion

    }
}

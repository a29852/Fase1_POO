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
    internal class Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Pessoa
        /// </summary>

        int idade;
        string sexo;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicia uma pessoa com idade a 0 e sexo como vazio
        /// </summary>

        public Pessoa()
        {
            idade = 0;
            sexo = "";
        }

        #endregion

        #region PROPRIEDADES

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


        public string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        #endregion

        #region METODOS

        public override bool Equals(object obj)
        {
            Pessoa p = (Pessoa)obj;

            if (this.sexo == p.sexo || this.idade == p.idade)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}

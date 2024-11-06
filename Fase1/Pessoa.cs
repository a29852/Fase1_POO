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

        int idade;
        string sexo;

        #endregion

        #region CONSTRUTORES

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
    }
}

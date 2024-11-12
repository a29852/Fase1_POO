/**
 * Gustavo Pereira
 * a29852@alunos.ipca.pt
 */


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Alojamentos
    {

        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Alojamentos
        /// </summary>

        const int MAXALOJ = 20;
        static Alojamento[] alojamentos;
        static int totAloj = 0;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que serve para criar um array de Alojamentos
        /// </summary>

        static Alojamentos()
        {
            alojamentos = new Alojamento[MAXALOJ];
            totAloj = 0;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// A função "RegistarAlojamentos" regista um novo alojamento caso exista disponibilidade no array
        /// </summary>
        /// <param name="a">A função recebe um objeto "Alojamento" como parâmetro</param>


        public static bool RegistarAlojamentos(Alojamento a)
        {
            if (totAloj < MAXALOJ)
            {
                alojamentos[totAloj++] = a;
                return true;
            }

            return false;
        }

        /// <summary>
        /// A função procura um objeto "Alojamento" e retorna se o encontrar
        /// </summary>
        /// <param name="numero">O parâmetro é um número inteiro que representa o número do alojamento que se procura</param>

        public static Alojamento PequisarAlojamento(int numero)
        {
            foreach (Alojamento alojamento in alojamentos)
            {
                if ( alojamento.Numero == numero)
                {
                    return alojamento;
                }
            }
            return null;
        }

        /// <summary>
        /// A função "AmostrarAlojamentos" cria um novo array e copia os elementos do array existente para no fim retornar o array
        /// </summary>
        public static Alojamento[] AmostrarAlojamentos()
        {
            Alojamento[] totalAlojamentos = new Alojamento[totAloj];

            for (int i = 0; i < totAloj; i++)
            {
                totalAlojamentos[i] = alojamentos[i];
            }

            return totalAlojamentos;
        }

        #endregion
    }
}

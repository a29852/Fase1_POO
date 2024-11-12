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
    internal class Clientes
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Clientes
        /// </summary>
        
        const int MAXCLIENTES = 20;
        static Cliente[] clientes;
        static int totClientes = 0;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que serve para criar um array de Clientes
        /// </summary>
        static Clientes()
        {
            clientes = new Cliente[MAXCLIENTES];
            totClientes = 0;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// A função regista um novo Cliente caso exista espaço no array
        /// </summary>
        /// <param name="c">A função recebe um objeto "Cliente" como parametro</param>
        /// <returns></returns>

        public static bool RegistarCliente(Cliente c)
        {
            if (totClientes < MAXCLIENTES)
            {
                clientes[totClientes++] = c;
                return true;
            }

            return false;
        }

        /// <summary>
        /// A função procura um Cliente e retorna se o encontrar
        /// </summary>
        /// <param name="id">O parametro é um numero inteiro que representa a identificação do cliente que se procura</param>
        /// <returns></returns>

        public static Cliente PequisarCliente(int id)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }
            return null;
        }

        /// <summary>
        /// A função cria um novo array para poder retornar os clientes que existem
        /// </summary>
        /// <returns></returns>

        public static Cliente[] AmostrarClientes()
        {
            Cliente[] totalClientes = new Cliente[totClientes];

            for (int i = 0; i < totClientes; i++)
            {
                totalClientes[i] = clientes[i];
            }

            return totalClientes;
        }


        #endregion
    }
}

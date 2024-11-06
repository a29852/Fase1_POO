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

        const int MAXCLIENTES = 20;
        static Cliente[] clientes;
        static int totClientes = 0;

        #endregion

        #region CONSTRUTORES

        static Clientes()
        {
            clientes = new Cliente[MAXCLIENTES];
            totClientes = 0;
        }

        #endregion

        #region METODOS

        public static bool RegistarCliente(Cliente c)
        {
            if (totClientes < MAXCLIENTES)
            {
                clientes[totClientes++] = c;
                return true;
            }

            return false;
        }

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

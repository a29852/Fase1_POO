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

        Cliente[] clientes;
        int tot = 0;

        #endregion

        #region CONSTRUTORES

        public Clientes(int n)
        {
            clientes = new Cliente[n];
        }

        #endregion

        #region METODOS

        public bool RegistarCliente(Cliente c)
        {
            if (tot < clientes.Length)
            {
                clientes[tot++] = c;
                return true;
            }

            return false;
        }

        public Cliente PequisarCliente(int nif)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Nif == nif)
                {
                    return cliente;
                }
            }
            return null;
        }


        public Cliente[] AmostrarClientes()
        {
            Cliente[] totalClientes = new Cliente[tot];

            for (int i = 0; i < tot; i++)
            {
                totalClientes[i] = clientes[i];
            }

            return totalClientes;
        }


        #endregion
    }
}

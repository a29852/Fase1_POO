using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLIENTE
            Cliente c1 = new Cliente(1, "Joao", 999, 30, "M");
            Cliente c2 = new Cliente(2, "maria", 111, 22, "F");

            Clientes.RegistarCliente(c1);
            Clientes.RegistarCliente(c2);

            Console.WriteLine("Pesquisar cliente 2");
            Cliente aux = Clientes.PequisarCliente(2);
            Console.WriteLine("nome: " + aux.Nome.ToString());
            Console.WriteLine("id: " + aux.Id.ToString());

            Console.WriteLine("Clientes existentes: ");
            Cliente[] listaClientes = Clientes.AmostrarClientes();

            
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.Nome);
            }



            //ALOJAMENTO
            Alojamento a1 = new Alojamento(1, "casa", "braga", 12, true);
            Alojamento a2 = new Alojamento(2, "apartamento", "barcelos", 10, true);
            Alojamento a3 = new Alojamento(3, "apartamento", "porto", 10, true);

            Alojamentos.RegistarAlojamentos(a1);
            Alojamentos.RegistarAlojamentos(a2);
            Alojamentos.RegistarAlojamentos(a3);

            Console.WriteLine("Pesquisar alojamento 2: ");
            Alojamento aux2 = Alojamentos.PequisarAlojamento(2);
            Console.WriteLine("localidade: " + aux2.Localizacao.ToString());
            Console.WriteLine("disponibilidade: " + aux2.Disponivel.ToString());

            Console.WriteLine("Alojamentos Existentes: ");
            Alojamento[] listaAlojamentos = Alojamentos.AmostrarAlojamentos();

            foreach (Alojamento alojamento in listaAlojamentos)
            {
                Console.WriteLine(alojamento.Localizacao);
            }


            //RESERVA
            var date = new DateTime(2024, 11, 12, 00, 00, 00);
            Reserva r1 = new Reserva(1, c1, a2, date);
            Reserva r2 = new Reserva(2, c2, a1, date);


            Console.WriteLine("Alojamentos Disponiveis: ");
            Alojamento[] listaAlojamentosD = Alojamentos.AmostrarAlojamentos();

            foreach (Alojamento alojamento in listaAlojamentos)
            {
                if(alojamento.Disponivel == true)
                {
                    Console.WriteLine(alojamento.Localizacao);
                }
            }


            Reservas.RegistarReservas(r1);
            Reservas.RegistarReservas(r2);

            Reserva aux3 = Reservas.PequisarReserva(2);
            Console.WriteLine("Cliente: " + aux3.Cliente.Nome.ToString());
            Console.WriteLine("Alojamento: " + aux3.Alojamento.Localizacao.ToString());
            Console.WriteLine("DataFim: " + aux3.DataFim.ToString());


            Reservas.ModificarReserva(r2, a3);

            Console.WriteLine("Alojamentos Disponiveis: ");
            Alojamento[] listaAlojamentosD2 = Alojamentos.AmostrarAlojamentos();

            foreach (Alojamento alojamento in listaAlojamentos)
            {
                if (alojamento.Disponivel == true)
                {
                    Console.WriteLine(alojamento.Localizacao);
                }
            }

            Console.ReadLine();
        }
    }
}

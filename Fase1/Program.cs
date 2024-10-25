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
            Cliente c1 = new Cliente(1, "Joao", 999, 30);
            Cliente c2 = new Cliente(2, "maria", 111, 22);

            Clientes clientes1 = new Clientes(30);
            clientes1.RegistarCliente(c1);
            clientes1.RegistarCliente(c2);

            Cliente aux = clientes1.PequisarCliente(2);
            Console.WriteLine("nome: " + aux.Nome.ToString());
            Console.WriteLine("nif: " + aux.Nif.ToString());



            Cliente[] listaClientes = clientes1.AmostrarClientes();

            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.Nome);
            }



            //ALOJAMENTO
            Alojamento a1 = new Alojamento(1, "casa", "braga", 12, true);
            Alojamento a2 = new Alojamento(2, "apartamento", "barcelos", 10, true);

            Alojamentos alojamentos1 = new Alojamentos(30);
            alojamentos1.RegistarAlojamentos(a1);
            alojamentos1.RegistarAlojamentos(a2);

            Alojamento aux2 = alojamentos1.PequisarAlojamento(2);
            Console.WriteLine("localidade: " + aux2.Localizacao.ToString());
            Console.WriteLine("disponibilidade: " + aux2.Disponivel.ToString());


            Alojamento[] listaAlojamentos = alojamentos1.AmostrarAlojamentos();

            foreach (Alojamento alojamento in listaAlojamentos)
            {
                Console.WriteLine(alojamento.Localizacao);
            }

            //RESERVA
            var date = new DateTime(2024, 11, 12, 00, 00, 00);
            Reserva r1 = new Reserva(1, c1, a2, date);
            Reserva r2 = new Reserva(2, c2, a1, date);

            Reservas reservas1 = new Reservas(30);
            reservas1.RegistarReservas(r1);
            reservas1.RegistarReservas(r2);

            Reserva aux3 = reservas1.PequisarReserva(2);
            Console.WriteLine("Cliente: " + aux3.Cliente.Nome.ToString());
            Console.WriteLine("Alojamento: " + aux3.Alojamento.Localizacao.ToString());
            Console.WriteLine("DataFim: " + aux3.DataFim.ToString());

            Console.ReadLine();
        }
    }
}

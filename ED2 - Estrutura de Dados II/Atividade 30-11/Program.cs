using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportePilha.Models;

namespace TransportePilha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> trans = new List<Transporte>();
            Garagens gar = new Garagens();
            Veiculos vei = new Veiculos();
            Viagens via = new Viagens();
            int opc;
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Consultar garagem");
            Console.WriteLine("3. Iniciar jornada");
            Console.WriteLine("4. Encerrar jornada");
            Console.WriteLine("5. Liberar viagem de uma determinada origem para um determinado destino");
            Console.WriteLine("6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)");
            Console.WriteLine("7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino");
            Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");
            Console.WriteLine("9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino");
            Console.WriteLine("Escolha uma opção: ");
            opc = int.Parse(Console.ReadLine());
            

            while (opc != 0)
            {
                if (opc == 1)
                {
                    Console.WriteLine("Digite a placa do veiculo:");
                    string placa = Console.ReadLine();
                    Console.WriteLine("Digite a lotação do veiculo:");
                    int lot = int.Parse(Console.ReadLine());
                    Veiculo v = new Veiculo();
                    v.Placa = placa;
                    v.Lotacao = lot;
                    vei.incluir(v);

                }
                if (opc == 2)
                {
                    Console.WriteLine("Digite o local da garagem:");
                    string local = Console.ReadLine();
                    Garagem g = new Garagem();
                    g.Local = local;
                    gar.incluir(g);

                }
                if (opc == 3)
                {
                    gar.iniciarJornada();
                    Console.WriteLine("Jornada Iniciada");
                }
                if (opc == 4)
                {
                    gar.encerrarJornada(trans);
                    Console.WriteLine("Jornada Encerrada");

                }
                if (opc == 5)
                {
                    Viagem v = new Viagem();
                    Garagem go = new Garagem();
                    Garagem gd = new Garagem();
                    Veiculo ve = new Veiculo();
                    Console.WriteLine("Digite o local da garagem de origem:");
                    string local = Console.ReadLine();
                    go.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(go))
                        {
                            go = g2;
                        }
                    }
                    Console.WriteLine("Digite o local da garagem de destino:");
                    local = Console.ReadLine();
                    gd.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(gd))
                        {
                            gd = g2;
                        }
                    }
                    Console.WriteLine("Digite a placa do veiculo:");
                    string placa = Console.ReadLine();
                    ve.Placa = placa;

                    foreach (Veiculo v2 in vei.Veiculosl)
                    {
                        if (v2.Equals(ve))
                        {
                            ve = v2;
                        }
                    }
                    v.Origem = go;
                    v.Destino = gd;
                    v.Veiculo = ve;
                    via.incluir(v);
                }
                if (opc == 6)
                {
                    Console.WriteLine("Digite o local da garagem:");
                    string local = Console.ReadLine();
                    Garagem g = new Garagem();
                    g.Local = local;
                    foreach (Garagem ga in gar.Garagensl)
                    {
                        if (ga.Equals(g))
                        {
                            foreach (Veiculo ve in g.Veiculos)
                            {
                                Console.WriteLine("Veiculo= " + ve.Placa);
                            }

                        }

                    }

                }
                if (opc == 7)
                {
                    Viagem v = new Viagem();
                    Garagem go = new Garagem();
                    Garagem gd = new Garagem();
                    
                    Console.WriteLine("Digite o local da garagem de origem:");
                    string local = Console.ReadLine();
                    go.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(go))
                        {
                            go = g2;
                        }
                    }
                    Console.WriteLine("Digite o local da garagem de destino:");
                    local = Console.ReadLine();
                    gd.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(gd))
                        {
                            gd = g2;
                        }
                    }

                    v.Origem = go;
                    v.Destino = gd;
                    int qtdv = 0;
                    foreach (Viagem v2 in via.Viagensl)
                    {
                        if (v2.Equals(v))
                        {
                            qtdv++;
                        }
                    }
                    Console.WriteLine("quantidade de viagens:= " + qtdv);
                }
                if (opc == 8)
                {

                    Viagem v = new Viagem();
                    Garagem go = new Garagem();
                    Garagem gd = new Garagem();

                    Console.WriteLine("Digite o local da garagem de origem:");
                    string local = Console.ReadLine();
                    go.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(go))
                        {
                            go = g2;
                        }
                    }
                    Console.WriteLine("Digite o local da garagem de destino:");
                    local = Console.ReadLine();
                    gd.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(gd))
                        {
                            gd = g2;
                        }
                    }

                    v.Origem = go;
                    v.Destino = gd;

                    foreach (Viagem v2 in via.Viagensl)
                    {
                        if (v2.Equals(v))
                        {
                            Console.WriteLine("Id= " + v2.Id + "Origem= " + v2.Origem.Local + "Destino= " + v2.Destino.Local + "Veiculo= " + v2.Veiculo.Placa); 
                        }
                    }
                }
                if (opc == 9)
                {
                    Viagem v = new Viagem();
                    Garagem go = new Garagem();
                    Garagem gd = new Garagem();

                    Console.WriteLine("Digite o local da garagem de origem:");
                    string local = Console.ReadLine();
                    go.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(go))
                        {
                            go = g2;
                        }
                    }
                    Console.WriteLine("Digite o local da garagem de destino:");
                    local = Console.ReadLine();
                    gd.Local = local;

                    foreach (Garagem g2 in gar.Garagensl)
                    {
                        if (g2.Equals(gd))
                        {
                            gd = g2;
                        }
                    }

                    v.Origem = go;
                    v.Destino = gd;
                    int qtdl = 0;
                    foreach (Viagem v2 in via.Viagensl)
                    {
                        if (v2.Equals(v))
                        {
                            qtdl = qtdl + v2.Veiculo.Lotacao;
                        }
                    }
                    Console.WriteLine("Quantidade de passageiros= " + qtdl);
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2. Consultar garagem");
                Console.WriteLine("3. Iniciar jornada");
                Console.WriteLine("4. Encerrar jornada");
                Console.WriteLine("5. Liberar viagem de uma determinada origem para um determinado destino");
                Console.WriteLine("6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)");
                Console.WriteLine("7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino");
                Console.WriteLine("Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientesCadastrados = new List<Cliente>();
            Fila fila = new Fila();

            //Menu do usuário
            char opcao;
            int tipo;

            do
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                   SAC - Banco JK                           ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("     Escolha a opção da próxima operação a ser realizada:   ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("             1 - Cadastrar cliente.                         ");
                Console.WriteLine("             2 - Adicionar cliente na fila.                 ");
                Console.WriteLine("             3 - Listar a fila.                             ");
                Console.WriteLine("             4 - Atender cliente.                           ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("************************************************************");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                  Digite 'q' para sair.                     ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("************************************************************");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("\nCadastrar cliente\n");

                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        //A variável está sendo declarada porque o C#
                        //Exige que sejam declaradas antes de utilizadas

                        Console.WriteLine("Endereço: ");
                        string endereco = Console.ReadLine();

                        Console.WriteLine("Email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine("Celular: ");
                        string celular = (Console.ReadLine());

                        Console.WriteLine("CPF: ");
                        string cpf = (Console.ReadLine());

                        do
                        {
                            Console.WriteLine("\nO cliente é prioritário? ");
                            Console.WriteLine("Digite 1 para cliente não prioritário.");
                            Console.WriteLine("Digite 2 para cliente prioritário.");
                            tipo = int.Parse(Console.ReadLine());

                        } while (tipo < 1 && tipo > 2);
                        {
                            //Enquanto o usuário não digitar um valor válido, ficará em looping.

                            switch (tipo)
                            {
                                case 1:
                                    Cliente novo_cliente = new Cliente(nome, endereco, email, celular, cpf);
                                    clientesCadastrados.Add(novo_cliente);
                                    Console.WriteLine("Cliente cadastrado com sucesso!");
                                    break;
                                case 2:
                                    Console.Write("\nDigite a idade do cliente: ");
                                    int idade = int.Parse(Console.ReadLine());

                                    ClientePrioritario novo_cliente_prioritario = new ClientePrioritario(nome, endereco, email, celular, cpf, idade);
                                    clientesCadastrados.Add(novo_cliente_prioritario);
                                    Console.WriteLine("Cliente prioritário cadastrado com sucesso!");
                                    break;
                                default:
                                    Console.WriteLine("Valor inválido!");
                                    break;
                            }
                        }
                        break;

                    case '2':
                        if (clientesCadastrados.Count == 0)
                        {
                            Console.WriteLine("\nAinda não há clientes cadastrados.");
                            break;
                        }

                        Console.WriteLine("Listagem de clientes cadastrados: ");
                        foreach (var cliente in clientesCadastrados)
                        {
                            cliente.ExibirCadastro();
                            Console.WriteLine("\n\n************************************************************\n\n");
                        }

                        Console.WriteLine("Para adicionar o cliente a fila, informe o ID do mesmo: ");
                        int IdCliente = int.Parse(Console.ReadLine());

                        Cliente clienteSelecionado = clientesCadastrados.FirstOrDefault(c => c.Id == IdCliente);

                        if (clienteSelecionado != null)
                        {
                            fila.AdicionarNaFila(clienteSelecionado);
                            Console.WriteLine("\nCliente adicionado à fila!");
                        }
                        else
                        {
                            Console.WriteLine("\nID não encontrado no sistema.");
                        }
                        break;
                    //case '3':
                    //    var clientesPrioritarios = clientesCadastrados.Where(c => c is ClientePrioritario).ToList();

                    //    if (clientesCadastrados.Count == 0)
                    //    {
                    //        Console.WriteLine("Ainda não há clientes cadastrados.");
                    //        break;
                    //    }

                    //    Console.WriteLine("Listagem de clientes cadastrados: ");
                    //    foreach (var cliente in clientesCadastrados)
                    //    {
                    //        cliente.ExibirCadastro();
                    //        Console.WriteLine("\n\n************************************************************\n\n");
                    //    }

                    //    Console.WriteLine("Para adicionar o cliente prioritário à fila, informe o ID do mesmo: ");
                    //    int IdPrioritario = int.Parse(Console.ReadLine());

                    //    Cliente clientePrioritarioSelecionado = clientesPrioritarios.FirstOrDefault(c => c.Id == IdPrioritario);

                    //    if (clientePrioritarioSelecionado != null)
                    //    {
                    //        fila.AdicionarNaFila(clientePrioritarioSelecionado);
                    //        Console.WriteLine("Cliente prioritário adicionado à fila!");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("ID não encontrado ou o cliente não é prioritário.");
                    //    }
                    //    break;

                    case '3':
                        Console.WriteLine("Listagem da fila: ");
                        fila.ListarClientes();
                        break;

                    case '4':

                        fila.AtenderCliente();
                        Console.WriteLine("Atendimento realizado.");

                        break;

                    case 'q':
                        Console.WriteLine("Operação finalizada.");
                        break;

                    case 'Q':
                        Console.WriteLine("Operação finalizada.");
                        break;

                    default:
                        Console.WriteLine("Valor digitado inválido!");
                        break;
                }

            } while (opcao != 'q' && opcao != 'Q');
        }
    }
}

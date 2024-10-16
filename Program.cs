using System;
using System.Collections.Generic;

namespace CadastroClientesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteManager clienteManager = new ClienteManager();
            bool executando = true;

            while (executando)
            {
                try
                {
                    ExibirMenu();
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            clienteManager.AdicionarCliente();
                            break;
                        case 2:
                            clienteManager.VisualizarClientes();
                            break;
                        case 3:
                            clienteManager.EditarCliente();
                            break;
                        case 4:
                            clienteManager.ExcluirCliente();
                            break;
                        case 5:
                            executando = false;
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida! Por favor, insira um número.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1 - Adicionar cliente");
            Console.WriteLine("2 - Visualizar clientes");
            Console.WriteLine("3 - Editar cliente");
            Console.WriteLine("4 - Excluir cliente");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
        }
    }

    public class ClienteManager
    {
        private List<Cliente> clientes;

        public ClienteManager()
        {
            clientes = new List<Cliente>();
        }

        public void AdicionarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não pode ser vazio!");
                return;
            }

            Console.Write("Digite o e-mail do cliente: ");
            string email = Console.ReadLine();
            if (!ValidadorEmail.Validar(email))
            {
                Console.WriteLine("E-mail inválido!");
                return;
            }

            Cliente novoCliente = new Cliente(nome, email);
            clientes.Add(novoCliente);
            Console.WriteLine("Cliente adicionado com sucesso.");
        }

        public void VisualizarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            Console.WriteLine("\nClientes cadastrados:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        public void EditarCliente()
        {
            Console.Write("Digite o nome do cliente que deseja editar: ");
            string nome = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.Write("Digite o novo nome do cliente (ou pressione Enter para manter o nome atual): ");
            string novoNome = Console.ReadLine();
            if (!string.IsNullOrEmpty(novoNome)) cliente.Nome = novoNome;

            Console.Write("Digite o novo e-mail do cliente (ou pressione Enter para manter o e-mail atual): ");
            string novoEmail = Console.ReadLine();
            if (!string.IsNullOrEmpty(novoEmail) && ValidadorEmail.Validar(novoEmail)) cliente.Email = novoEmail;

            Console.WriteLine("Cliente editado com sucesso.");
        }

        public void ExcluirCliente()
        {
            Console.Write("Digite o nome do cliente que deseja excluir: ");
            string nome = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            clientes.Remove(cliente);
            Console.WriteLine("Cliente excluído com sucesso.");
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, E-mail: {Email}";
        }
    }

    public static class ValidadorEmail
    {
        public static bool Validar(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}

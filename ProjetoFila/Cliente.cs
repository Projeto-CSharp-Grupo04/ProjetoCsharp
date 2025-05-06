using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    public class Cliente
    {
        private static int valorId = 1;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }


        //public Cliente()
        //{
        //    Id = valorId++;
        //}


        public Cliente(string nome, string endereco, string email, string celular, string cpf)

        {
            Id = valorId++;
            Nome = nome;
            Endereço = endereco;
            Email = email;
            Celular = celular;
            Cpf = cpf;

        }
        public virtual void ExibirCadastro()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereço}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Celular: {Celular}");
            Console.WriteLine($"CPF: {Cpf}");
            //Anotação: O $ serve para inserir variáveis
            //diretamente dentro da string
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    //Herdando a classe Cliente
    public class ClientePrioritario : Cliente
    {
        public int Idade { get; set; }

        public ClientePrioritario(string nome, string endereco, string email, string celular, string cpf, int idade) : base(nome, endereco, email, celular, cpf)
        {
            Idade = idade;
        }

        public override void ExibirCadastro()
        {
            base.ExibirCadastro();
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}

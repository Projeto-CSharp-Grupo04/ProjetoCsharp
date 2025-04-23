using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Fila
    {
        protected int tamanho;
        protected Cliente[] fila_comum;
        protected ClientePrioritario[] fila_prioritaria;
        public void DefinirTamanhoDaFila(int tamanho)
        {
            this.fila_comum = new Cliente[tamanho];
            this.fila_prioritaria = new ClientePrioritario[tamanho];
            this.tamanho = tamanho;
        }
        public void InserirNaFila(Cliente cliente)
        {
            this.fila_comum.Append(cliente);
            Console.WriteLine("Novo cliente na fila:");
            cliente.exibirDados();
        }
        public void InserirNaFila(ClientePrioritario cliente)
        {
            this.fila_prioritaria.Append(cliente);
            Console.WriteLine("Novo cliente na fila prioritario:");
            cliente.exibirDados();
        }
        public void ListarClientesNaFila()
        {
            Console.WriteLine("Clientes na fila prioritária:");
            /*for (int i = 0; i < this.fila_prioritaria.Count(); i++)
            {
                this.fila_prioritaria[i].exibirDados();
            }*/
            Console.WriteLine("Clientes na fila comum:");
            for (int i = 0; i < this.fila_comum.Count(); i++)
            {
                Console.WriteLine(this.fila_comum.);
                //this.fila_comum[i].exibirDados();
            }
        }
        public void AtenderOPróximo()
        {
            if (this.fila_prioritaria.Count() > 0)
            {
                this.fila_prioritaria.First().Atender();
                this.fila_prioritaria.CopyTo(this.fila_prioritaria, 1);
            }
            else if (this.fila_comum.Count() > 0)
            {
                this.fila_comum.First().Atender();
                this.fila_comum.CopyTo(this.fila_comum, 1);
            }
            else
            {
                Console.WriteLine("A fila está vazia");
            }
        }
    }
}
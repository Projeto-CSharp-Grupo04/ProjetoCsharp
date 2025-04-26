using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Fila
    {
        // a fila de todas os clientes
        protected List<Cliente> fila = new List<Cliente>();

        // tamanho máximo da fila
        protected int tamanho_maximo = 10;

        // inserir um cliente na fila
        public void Adicionar(Cliente novo_cliente)
        {
            // só continuar se a fila couber
            if (fila.Count < tamanho_maximo)
            {
                // ações diferentes para clientes prioritários
                if (novo_cliente is ClientePrioritario)
                {
                    // procurar pelo último cliente prioritário na fila
                    int ultima_posicao = fila.FindLastIndex(cliente_na_fila => cliente_na_fila is ClientePrioritario);

                    // não achou nenhum cliente prioritário
                    if (ultima_posicao < 0)
                    {
                        // coloca no começo da fila
                        fila.Insert(0, novo_cliente);
                    }
                    else
                    {
                        // coloca atrás do último cliente prioritário
                        fila.Insert(ultima_posicao + 1, novo_cliente);
                    }
                }
                else
                {
                    // colocar no final
                    fila.Add(novo_cliente);
                }
            }
            else
            {
                // mensagem de erro ao inserir na fila por causa do tamanho máximo
                FilaCheia();
            }
        }

        // antender o primeiro cliente
        public void Atender()
        {
            // verificar se tem clientes na fila
            if (fila.Count > 0)
            {
                // tirar da fila o primeiro cliente
                fila.RemoveAt(0);
            }
            else
            {
                // mensagem de erro ao remover da fila pois já está vazia
                FilaVazia();
            }
        }

        // mostrar o tamanho da fila
        public int Tamanho()
        {
            // retorna o número de clientes na fila
            return fila.Count;
        }

        // mudar o tamanho da fila
        public void DefinirTamanhoMaximo(int novo_tamanho_maximo)
        {
            // altera o tamanho máximo de clientes na fila
            tamanho_maximo = novo_tamanho_maximo;
        }
    }
}
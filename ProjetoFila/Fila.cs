using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    internal class Fila
    {
        // a fila de todos os clientes
        protected Cliente[] fila = new Cliente[10];

        // tamanho atual da fila
        protected int tamanhoAtual = 0;

        // tamanho máximo da fila
        protected int tamanhoMaximo = 10;

        // inserir um cliente na fila
        public int AdicionarNaFila(Cliente novo_cliente)
        {
            // só continuar se a fila couber
            if (tamanhoAtual < tamanhoMaximo)
            {
                // ações diferentes para clientes prioritários
                if (novo_cliente is ClientePrioritario)
                {
                    // -1 para indicar que pode não haver prioritários na fila
                    int ultima_posicao = -1;

                    // procurar pelo último cliente prioritário na fila
                    for (int posicao = 0; posicao < tamanhoAtual; posicao++)
                    {
                        // verificação de instância de classe (se objeto x é de tal classe)
                        if (fila[posicao] is ClientePrioritario)
                        {
                            // essa é a posição do último prioritário
                            ultima_posicao = posicao;
                        }
                    }
                    // mover todos atrás do último cliente prioritário uma posição para trás para dar espaço para o novo cliente prioritário
                    for (int posicao = tamanhoAtual; posicao > ultima_posicao + 1; posicao--)
                    {
                        // se você tá em 2o você vai pra 3o etc, em cascata do fim até o início para não ter sobreposição e, com isso, evitando perda de clientes da fila
                        fila[posicao] = fila[posicao - 1];
                    }
                    // aqui insere logo após o último, agora que tem espaço. caso não tenha outros prioritários, aquele -1 vira 0 aqui (primeira posição)
                    fila[ultima_posicao + 1] = novo_cliente;
                }
                else
                {
                    // colocar no final os clientes normais
                    fila[tamanhoAtual] = novo_cliente;
                }
                // atualiza tamanho da fila
                tamanhoAtual++;

                // tudo certo
                return 0;
            }
            else
            {
                // mensagem de erro ao inserir na fila por causa do tamanho máximo
                //Console.WriteLine("A fila está cheia");

                // melhor o menú lidar com a mensagem de erro, então há um retorno dizendo se deu erro ou não
                return 1;
            }
        }
        // antender o primeiro cliente
        public int AtenderCliente()
        {
            // check de fila vazia
            if (tamanhoAtual > 0)
            {
                // remove o primeiro da fila
                fila[0] = null;

                // avançar todos os clientes uma posição. esse -1 impede o acesso fora do vetor como fila[9+1]
                for (int posicao = 0; posicao < tamanhoAtual - 1; posicao++)
                {
                    fila[posicao] = fila[posicao + 1];
                }
                // atualizar o tamanho da fila
                tamanhoAtual--;

                // tudo certo
                return 0;
            }
            else
            {
                // retorno de erro de fila já vazia
                return 1;
            }
        }
        // listar todos o clientes na fila
        public int ListarClientes()
        {
            // check de tamanho
            if (tamanhoAtual > 0)
            {
                // rodar todas as posições do vetor
                for (int posicao = 0; posicao < tamanhoAtual; posicao++)
                {
                    // mensagem de listagem
                    Console.WriteLine("{0}. {1}", posicao + 1, fila[posicao].Nome);
                }
                // tudo certo
                return 0;
            }
            else
            {
                // retorno de erro de fila vazia
                return 1;
            }
        }
    }
}

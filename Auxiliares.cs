using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncriptografadorEnigma
{
    public class Auxiliares
    {
        
        public static void MessageBoxOK(string mensagem, string legenda)
        {
            
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            DialogResult resultado;

            // Mostra a MessageBox.

            resultado = MessageBox.Show(mensagem, legenda, botoes);
            
        }

        public static void MessageBoxYesNo(string mensagem, string legenda)
        {

            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado;

            // Mostra a MessageBox.

            resultado = MessageBox.Show(mensagem, legenda, botoes);

        }

        public static int intRandomico(int min, int max)
        {
            Random geradorDeRandomico = new Random();
            int inteiroRandomico = 0;

            inteiroRandomico = geradorDeRandomico.Next(min, max);

            return inteiroRandomico;
            
        }

        // Função para checar se é número primo
        public static bool verificacaoDePrimo(int posicaoPrimo)
        {
            // Inicializa variável local
            bool checaB = false; // Sempre retorana "false", salvo caso prove o contrário, abrange o caso 1 e 0
            int checaIP = posicaoPrimo;

        // Loop sobre o número, contagem regressiva até 2
          while (checaIP > 1)
          {
               // Verifica o resto e diminui se houver algum remanescente
                if ((posicaoPrimo != 1) && (posicaoPrimo != 0) && (checaIP != 2) &&((posicaoPrimo % (checaIP - 1)) != 0))
                {
                    checaIP--;
                }
                // Executado se não possui resto, portanto é divisivel
                else if ((posicaoPrimo != 1) && (posicaoPrimo != 0) && (checaIP  != 2) && ((posicaoPrimo % (checaIP - 1)) == 0))
                {
                    checaB = false;
                   break;
                }
                    // Executa se for 2, pois 2 sempre é primo
                else if (checaIP == 2)
                {
                    checaB = true;
                    break;

                }

            }

            return checaB;
        }

        //Checa se certas Strings podem ser convertidas para int (Função de sistema)
        public static bool stiInputCheck(string s)
        {
            bool noException = true;

            try
            {
                Convert.ToInt32(s);

            }
            catch (FormatException)
            {
                noException = false;
            }
            catch (OverflowException)
            {
                noException = false;

            }

            return noException;
        }

        public static double DTR(double graus)
        {
            double rad = (double)(graus * (Math.PI / 180.0));
            return rad;
        }

        public static double RTD(double radianos)
        {
            double gra = (double)(radianos * (180 / Math.PI));
            return gra;
        }

        public static double raizXY(double raiz, double radicando)
        {
            double resultado = 0;

            resultado = Math.Pow(radicando, (1 / raiz));

            return resultado;
        }

        public static double Fatorial(double n)
        {
            double resultado = n;
            double contador = (n - 1);

            while (contador > 1)
            {
                resultado = resultado * contador;
                contador--;
            }

            return resultado;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncriptografadorEnigma
{
    public partial class Encriptografador : Form
    {
        string entrada = "";
        string saida = "";
        int processamentoItem = new int();
        int rotacao1 = new int();
        int rotacao2 = new int();
        int rotacao3 = new int();
        char testChar = ' ';
        static int comprimento = 94;
        Rotor chave1 = new Rotor(comprimento, 1);
        Rotor chave2 = new Rotor(comprimento, 2);
        Rotor chave3 = new Rotor(comprimento, 3);
        Auxiliares auxiliares = new Auxiliares();

        public Encriptografador()
        {
            InitializeComponent();
        }
        
        private void botaoEncriptaClique(object sender, EventArgs e)
        {
            rotacao1 = Convert.ToInt32(inicioTextoChave1.Text);
            rotacao2 = Convert.ToInt32(inicioTextoChave2.Text);
            rotacao3 = Convert.ToInt32(inicioTextoChave3.Text);
            entrada = rxtInput.Text;
            while (entrada.Length > 0)
            {
                //Pega o primeiro caracter e o muda para numero
                processamentoItem = decodificaLetraParaNumero(entrada.Substring(0, 1));
                //Encripta processamentoItem
                processamentoItem = rodaEncriptacao(processamentoItem);
                //Adiciona processamentoItem, muda para letra e adiciona para saida
                saida = saida + encodificaNumeroParaLetra(processamentoItem);
                //Remove o caracter transformado da sequência de caracteres
                entrada = entrada.Remove(0,1);
            }

            rxtSaida.Text = saida;
            saida = "";
        }

        private void botaoDecriptarClique(object sender, EventArgs e)
        {
            rotacao1 = Convert.ToInt32(inicioTextoChave1.Text);
            rotacao2 = Convert.ToInt32(inicioTextoChave2.Text);
            rotacao3 = Convert.ToInt32(inicioTextoChave3.Text);
            entrada = rxtInput.Text;
            while (entrada.Length > 0)
            {
                //Pega o primeiro caracter e o muda para numero
                processamentoItem = decodificaLetraParaNumero(entrada.Substring(0, 1));
                //Decripta processamentoItem
                processamentoItem = rodaDecriptacao(processamentoItem);
                //Adiciona processamentoItem, muda para letra e adiciona para saida
                saida = saida + encodificaNumeroParaLetra(processamentoItem);
                //Remove caracter processado pra String
                entrada = entrada.Remove(0, 1);
            }

            rxtSaida.Text = saida;
            saida = "";
        }

        public int rodaEncriptacao(int entradaDeEncriptacao)
        {
            int processoDeEncriptacaoDoItem = entradaDeEncriptacao;

            // Adiciona rotação a chave1
            processoDeEncriptacaoDoItem = (processoDeEncriptacaoDoItem + rotacao1) % comprimento;
            // Encripta chave1
            processoDeEncriptacaoDoItem = chave1.encripta(processoDeEncriptacaoDoItem);
            // Adiciona rotação a chave2
            processoDeEncriptacaoDoItem = (processoDeEncriptacaoDoItem + rotacao2) % comprimento;
            // Encripta chave2
            processoDeEncriptacaoDoItem = chave2.encripta(processoDeEncriptacaoDoItem);
            // Adiciona rotação a chave3
            processoDeEncriptacaoDoItem = (processoDeEncriptacaoDoItem + rotacao3) % comprimento;
            // Encripta chave2
            processoDeEncriptacaoDoItem = chave3.encripta(processoDeEncriptacaoDoItem);
            // Aumenta rotação a Chave1
            rotacao1++;
            // Aumenta rotação a chave2 se a chave1 for divisivel por 2
            if ((rotacao1 % 2) == 0)
                rotacao2++;
            // Aumenta rotação a chave3 se a chave2 for divisivel por 3
            if ((rotacao2 % 3) == 0)
                rotacao3++;
            // Se rotacao1 > 1 rotação total, reseta rotacao1
            if (rotacao1 > (comprimento - 1))
                rotacao1 = 0;
            // Se rotacao2 > 1 rotação total, reseta rotacao1
            if (rotacao2 > (comprimento - 1))
                rotacao2 = 0;
            // Se rotacao3 > 1 rotação total, reseta rotacao1
            if (rotacao3 > (comprimento - 1))
                rotacao3 = 0;
            // Saida
            return processoDeEncriptacaoDoItem;
        }

        public int rodaDecriptacao(int entradaDeDecriptacao)
        {
            int processoDeDecriptacaoDoItem = entradaDeDecriptacao;

            // Decripta chave3
            processoDeDecriptacaoDoItem = chave3.decripta(processoDeDecriptacaoDoItem);
            // Subtrai rotação da chave3
            if ((processoDeDecriptacaoDoItem - rotacao3) >= 0)
                processoDeDecriptacaoDoItem = processoDeDecriptacaoDoItem - rotacao3;
            else
                processoDeDecriptacaoDoItem = (processoDeDecriptacaoDoItem - rotacao3) + comprimento;
            // Decripta chave2
            processoDeDecriptacaoDoItem = chave2.decripta(processoDeDecriptacaoDoItem);
            // Subtrai rotação da chave2
            if ((processoDeDecriptacaoDoItem - rotacao2) >= 0)
                processoDeDecriptacaoDoItem = processoDeDecriptacaoDoItem - rotacao2;
            else
                processoDeDecriptacaoDoItem = (processoDeDecriptacaoDoItem - rotacao2) + comprimento;
            // Decripta chave1
            processoDeDecriptacaoDoItem = chave1.decripta(processoDeDecriptacaoDoItem);
            // Subtrai rotação da chave1
            if ((processoDeDecriptacaoDoItem - rotacao1) >= 0)
                processoDeDecriptacaoDoItem = processoDeDecriptacaoDoItem - rotacao1;
            else
                processoDeDecriptacaoDoItem = (processoDeDecriptacaoDoItem - rotacao1) + comprimento;
            // Aumenta rotação na chave1
            rotacao1++;
            // Aumenta rotação a chave2 se a chave1 for divisivel por 2
            if ((rotacao1 % 2) == 0)
                rotacao2++;
            // Aumenta rotação a chave3 se a chave2 for divisivel por 3
            if ((rotacao2 % 3) == 0)
                rotacao3++;
            // Se rotacao1 > 1 rotação total, reseta rotacao1
            if (rotacao1 > (comprimento - 1))
                rotacao1 = 0;
            // Se rotacao2 > 1 rotação total, reseta rotacao2
            if (rotacao2 > (comprimento - 1))
                rotacao2 = 0;
            // Se rotacao3 > 1 rotação total, reseta rotacao1
            if (rotacao3 > (comprimento - 1))
                rotacao3 = 0;
            //saida
            return processoDeDecriptacaoDoItem;
        }

        public int decodificaLetraParaNumero(string letra)
        {
            int numero = new int();
            char letraChar = Convert.ToChar(letra);
            numero = (Convert.ToInt32(letraChar)) - 32;

            return numero;
        }

        public string encodificaNumeroParaLetra(int numero)
        {
            string letra = "";
            char numeroChar = Convert.ToChar(numero);
            letra = (Convert.ToString((char) (numeroChar + 32)));

            return letra;
        }

        private void botaoResetClique(object sender, EventArgs e)
        {
            rotacao1 = 0;
            rotacao2 = 0;
        }

        private void rxtEntradaTextoAlterado(object sender, EventArgs e)
        {

        }

    }

}

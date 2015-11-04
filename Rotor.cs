using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncriptografadorEnigma
{
    class Rotor
    {
        int[] encriptacaoRotor;
        int[] decriptacaoRotor;
        int randomico1 = 0;
        bool checaRotor = false;
        public Random[] sementeRandomica;

        public Rotor(int comprimentoDoRotor, int rotorNum)
        {
            sementeRandomica = new Random[3];
            sementeRandomica[0] = new Random(4985);
            sementeRandomica[1] = new Random(203);
            sementeRandomica[2] = new Random(1004238);
            encriptacaoRotor = new int[comprimentoDoRotor];
            decriptacaoRotor = new int[comprimentoDoRotor];

                for (int k = 0; k < comprimentoDoRotor; k++)
                {
                    encriptacaoRotor[k] = -1;
                    decriptacaoRotor[k] = -1;
                }
                for (int i = 0; i < comprimentoDoRotor; i++)
                {
                    while (checaRotor == false)
                    {
                        randomico1 = sementeRandomica[rotorNum - 1].Next(comprimentoDoRotor);
                        checaRotor = true;
                        for (int j = 0; j < comprimentoDoRotor; j++)
                        {
                            if (encriptacaoRotor[j] == randomico1)
                                checaRotor = false;
                        }
                    }
                    checaRotor = false;
                    encriptacaoRotor[i] = randomico1;
                    decriptacaoRotor[randomico1] = i;

                }
        }

        public int encripta(int letra)
        {
            int letraEncriptada = new int();
            letraEncriptada = encriptacaoRotor[letra];
            return letraEncriptada;
        }

        public int decripta(int letra)
        {
            int letraDecriptada = new int();
            letraDecriptada = decriptacaoRotor[letra];
            return letraDecriptada;
        }
    }
}

using System;

namespace Diamante
{
    public class Diamante
    {
        readonly String[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        private readonly char letra;

        public Diamante(char letra)
        {
            this.letra = letra;
        }

        public String MontarDiamante()
        {
            int espacosExterior = ObterPosicaoDaLetra(letra)-1 ;
            String diamanteStr = "";
            int espacosInteriorSuperior = 1;
            int espacosInteriorInferior = 0;
        
            for (int i = 0; i < ObterPosicaoDaLetra(letra) -1; i++)
            {
                String espacosExteriorStr = new string(' ', espacosExterior);
                String espacosInteriorSuperiorStr = new string(' ', espacosInteriorSuperior);
                if (letras[i] == "A")
                {
                    diamanteStr += espacosExteriorStr + letras[i] + "\n";
                }
                else
                {
                    diamanteStr += espacosExteriorStr + letras[i] + espacosInteriorSuperiorStr + letras[i] + "\n";
                    espacosInteriorSuperior += 2;
                }
                espacosExterior -= 1;
                espacosInteriorInferior = espacosInteriorSuperior;
            }
            for (int i = ObterPosicaoDaLetra(letra) - 1; i >= 0; i--)
            {
                String espacosExteriorStr = new string(' ', espacosExterior);
                String espacosInteriorInferiorStr = new string(' ', (int)espacosInteriorInferior);
                if (letras[i] == "A")
                {
                    diamanteStr += espacosExteriorStr + letras[i] + "\n";
                }
                else
                {
                    diamanteStr += espacosExteriorStr + letras[i] + espacosInteriorInferiorStr + letras[i] + "\n";
                    if (letras[i] != "B") espacosInteriorInferior -= 2;
                }
                espacosExterior += 1;
            }

            return diamanteStr;
        }

        private int ObterPosicaoDaLetra(char letra)
        {
            return (int)letra % 32;
        }
    }
}

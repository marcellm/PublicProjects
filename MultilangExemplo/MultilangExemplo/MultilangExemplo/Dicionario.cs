using System;
using System.Collections.Generic;
using System.Text;

namespace MultilangExemplo
{
    public static class Dicionario
    {
        public static string Ola()
        {
            if (AppGlobalValues.idiomaApp == "pt-BR")
                return "Olá";
            else if (AppGlobalValues.idiomaApp == "en-US")
                return "Hello";
            else if (AppGlobalValues.idiomaApp == "es-ES")
                return "Hola";
            return "";
        }
    }
}

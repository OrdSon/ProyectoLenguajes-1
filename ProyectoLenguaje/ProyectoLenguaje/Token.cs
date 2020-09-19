using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguaje
{
    public class Token
    {
        public enum Tipo
        {
            TIPO_OBJETO,
            IDENTIFICADOR,
            VALOR_ENTERO,
            VALOR_DECIMAL,
            VALOR_CADENA,
            VALOR_BOOLEAN,
            VALOR_CHART,
            OPERADOR_ARITMETICO,
            OPERADOR_RELACIONAL,
            OPERADOR_LOGICO,
            AGRUPACION,
            DECLARACION,
            PALABRA_RESERVADA,
            COMENTARIO,
            COMMAS,
            ERROR
        }

        private Tipo tipoToken;
        private String valor;
        int linea;

        public Token(Tipo tipoToken, String valor, int linea)
        {
            this.tipoToken = tipoToken;
            this.valor = valor;
            this.linea = linea;
        }

        public String getValor()
        {
            return valor;
        }

        public string getTipo()
        {
            switch(tipoToken){
                case Tipo.TIPO_OBJETO:
                    return "tipo de objeto";                   
                case Tipo.IDENTIFICADOR:
                    return "identificador";
                case Tipo.VALOR_ENTERO:
                    return "valor entero";
                case Tipo.VALOR_DECIMAL:
                    return "valor decimal";
                case Tipo.VALOR_CADENA:
                    return "valor cadena";
                case Tipo.VALOR_BOOLEAN:
                    return "valor boolean";
                case Tipo.VALOR_CHART:
                    return "valor chart";
                case Tipo.OPERADOR_ARITMETICO:
                    return "operador aritmetico";
                case Tipo.OPERADOR_RELACIONAL:
                    return "operador relacional";
                case Tipo.OPERADOR_LOGICO:
                    return "operador logico";
                case Tipo.PALABRA_RESERVADA:
                    return "palabra reservada";
                case Tipo.AGRUPACION:
                    return "Agrupacion";
                case Tipo.COMMAS:
                    return "coma";
                case Tipo.COMENTARIO:
                    return "comentario";
                default:
                    return "ERROR";
            }
        }
    }
}

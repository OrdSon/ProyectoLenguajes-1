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
            ENTERO,
            DECIMAL,
            CADENA,
            BOOLEAN,
            CHART,
            IDENTIFICADOR_ENTERO,
            IDENTIFICADOR_DECIMAL,
            IDENTIFICADOR_CADENA,
            IDENTIFICADOR_BOOLEAN,
            IDENTIFICADOR_CHART,
            OPERADOR_MAS,
            OPERADOR_MENOS,
            OPERADOR_MAS_MAS,
            OPERADOR_MENOS_MENOS,
            OPERADOR_POR,
            OPERADOR_SLICE,
            OPERADOR_MAYOR,
            OPERADOR_MENOR,
            OPERADOR_MAYOR_IGUAL,
            OPERADOR_MENOR_IGUAL,
            OPERADOR_IGUAL_IGUAL,
            OPERADOR_NO_IGUAL,
            OPERADOR_OR,
            OPERADOR_AND,
            OPERADOR_NO,
            PARENTESIS_APERTURA,
            PARENTESIS_CIERRE,
            ASIGNACION_IGUAL,
            PUNTO_Y_COMA,
            SI,
            SINO,
            SINO_SI,
            MIENTRAS,
            HACER,
            DESDE,
            HASTA,
            INCREMENTO,
            BARRAS_COMENTARIO,
            COMMAS
        }

        private Tipo tipoToken;
        private String valor;

        public Token(Tipo tipoToken, String valor)
        {
            this.tipoToken = tipoToken;
            this.valor = valor;
        }

        public String getContenido()
        {
            return valor;
        }

        public string getTipo()
        {
            switch(tipoToken){
                case Tipo.ENTERO:
                    return "numero entero";                   
                case Tipo.DECIMAL:
                    return "decimal";
                case Tipo.CADENA:
                    return "cadena";                    
                case Tipo.BOOLEAN:
                    return "boolean"; 
                case Tipo.CHART:
                    return "chart";
                case Tipo.IDENTIFICADOR_ENTERO:
                    return "identificador entero";
                case Tipo.IDENTIFICADOR_DECIMAL:
                    return "identificador decimal";
                case Tipo.IDENTIFICADOR_CADENA:
                    return "identificador cadena";
                case Tipo.IDENTIFICADOR_BOOLEAN:
                case Tipo.IDENTIFICADOR_CHART:
                    return "identificador chart";
                case Tipo.OPERADOR_MAS:
                    return "identificador mas";
                case Tipo.OPERADOR_MENOS:
                    return "identificador menos";
                case Tipo.OPERADOR_MAS_MAS:
                    return "operador mas mas";
                case Tipo.OPERADOR_MENOS_MENOS:
                    return "operador menos menos";
                case Tipo.OPERADOR_POR:
                    return "operador por";
                case Tipo.OPERADOR_SLICE:
                    return "operador slash";
                case Tipo.OPERADOR_MAYOR:
                    return "operador mayor";
                case Tipo.OPERADOR_MENOR:
                    return "operador menor";
                case Tipo.OPERADOR_MAYOR_IGUAL:
                    return "operador mayor-igual";
                case Tipo.OPERADOR_MENOR_IGUAL:
                    return "operador menor-igual";
                case Tipo.OPERADOR_IGUAL_IGUAL:
                    return "operador igual-igual";
                case Tipo.OPERADOR_NO_IGUAL:
                    return "operadon no igual";
                case Tipo.OPERADOR_OR:
                    return "operador";
                case Tipo.OPERADOR_AND:
                    return "operador and";
                case Tipo.OPERADOR_NO:
                    return "operador no";
                case Tipo.PARENTESIS_APERTURA:
                    return "parentesis apertura";
                case Tipo.PARENTESIS_CIERRE:
                    return "parentesis cierre";
                case Tipo.ASIGNACION_IGUAL:
                    return "asignacion igual";
                case Tipo.PUNTO_Y_COMA:
                    return "punto & coma";
                case Tipo.SI:
                    return "if";
                case Tipo.SINO:
                    return "else";
                case Tipo.SINO_SI:
                    return "if else";
                case Tipo.MIENTRAS:
                    return "while";
                case Tipo.HACER:
                    return "do";
                case Tipo.DESDE:
                    return "from";
                case Tipo.HASTA:
                    return "hasta";
                case Tipo.INCREMENTO:
                    return "incremento";
                case Tipo.BARRAS_COMENTARIO:
                    return "barras comentario";
                case Tipo.COMMAS:
                    return "coma";
                default:
                    return "default";
            }
        }
    }
}

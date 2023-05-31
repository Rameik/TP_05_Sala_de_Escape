using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_05_Sala_de_Escape.Models
{
   public static class Escape
   {
      static string[] incognitasSalas = new string[3];
      static int estadoJuego = 1;

      private static void inicializarJuego(){
        incognitasSalas[0] = "Solucion sala 1";
        incognitasSalas[1] = "Solucion sala 2";
        incognitasSalas[2] = "Solucion sala 3";
        incognitasSalas[3] = "Solucion sala 4";
      }

      public static int getEstadoJuego(){
        return estadoJuego;
      }

      public static bool resolverSala(int sala, string incognita){
        if(incognitasSalas.Length == 0){
            inicializarJuego();
            return false;
        }
        else{
            if(sala > estadoJuego){
                return false;
            }
            else{
                if(incognitasSalas[sala] == incognita){
                    return true;
                    estadoJuego++;
                }
                else{
                    return false;
                }
            }
        }
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_05_Sala_de_Escape.Models
{
   public static class Escape
   {
      public static string[] incognitasSalas = new string[4];
      public static int estadoJuego = 1;

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
        if(incognitasSalas[0] == null){
            inicializarJuego();
        }
        if(sala > estadoJuego){
          return false;
        }
        else{
          if(incognitasSalas[sala - 1] == incognita){
            estadoJuego++;
            return true;
          }
          else{
            return false;
          }
        }
      }
   }
}

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
        incognitasSalas[0] = "DLMMST";
        incognitasSalas[1] = "MUESTRA";
        incognitasSalas[2] = "0543950";
        incognitasSalas[3] = "20938420";
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

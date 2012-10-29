using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
  public  class Bl_AntecedentesPersonales
    {

   

      public static bool Insert(Ent_AntecedentesPersonales entAntecedes)
      { 
      
          //Validaciones de Lugar


        return  Da_AntecedentesPersonales.Insert(entAntecedes);
                
      }


    }
}

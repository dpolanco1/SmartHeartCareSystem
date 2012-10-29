using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
 public   class Bl_HabitosToxicos
    {

     public static bool Insert(Ent_HabitosToxicos entHabitos)
     { 
     
        return Da_HabitosToxicos.Insert(entHabitos);
     
     }



    }
}

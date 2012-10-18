using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;


namespace BussinesLogicLayer
{
    public class Bl_Persona
    {

    Da_Persona daPersona = new Da_Persona();

        public void Insert(Ent_Persona entPersona)
        { 
            //Validaciones De Lugar


           daPersona.Insertar(entPersona);

                
        
        }

        public void Update(Ent_Persona entPersona)
        {

            //Validaciones De Lugar


            


        }

        public void Delete(Ent_Persona entPersona)
        {


        }

        public void Search(Ent_Persona entPersona)
        {


        }



    }
}

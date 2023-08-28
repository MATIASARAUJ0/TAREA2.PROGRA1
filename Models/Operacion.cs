using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appcomics.Models
{
    public class Operacion
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }


        public string Nombrar(){
            if(Genero == "MASCULINO" & Apellidos != null & Nombres != null){
                return ("¡Registrado Exitosamente!");
            }else if (Genero == "FEMENINO" & Apellidos != null & Nombres != null){
                return ("¡Registrada Exitosamente!");
            }else if(Genero == ""){
                return ("-");
            }else{
                return ("-");
            }
        }


    }
}
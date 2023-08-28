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
        public string Genero { get; set; }
        public string Categoria { get; set; }
        public int Edad { get; set; }
        public string Club { get; set; }

        public bool Temporada1 { get; set; }
        public bool Temporada2 { get; set; }
        public bool Temporada3 { get; set; }
        public bool Temporada4 { get; set; }


        public int Temporadas(){
            int total = 0;
            if (Temporada1) total += 1;
            if (Temporada2) total += 1;
            if (Temporada3) total += 1;
            if (Temporada4) total += 1;

            return total;
        }

        public string DefCategoria(){
            if("Sub 17" == Categoria ){
                return "Sub 17" ;
            }else if("Sub 20" == Categoria ){
                return "Sub 20" ;
            }else if("Mayores" == Categoria ){
                return "Mayores" ;
            }else{
                return "-";
            }
        }

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

        public int DefEdad(){
            return Edad;
        }

        public string DefNombres(){
            return Apellidos+" "+Nombres;
        }

        public string DefGenero(){
            return Genero;
        }

        public string DefClub(){
            if(Club == "Universitario"){
                return "Universitario de Deportes" ;
            }else if(Club == "Alianza"){
                return "Alianza Lima" ;
            }else if(Club == "Cienciano"){
                return "Club Cienciano" ;
            }else if(Club == "Cristal"){
                return "Sporting Cristal" ;
            }else{
                return "-";
            }
        }
    }
}
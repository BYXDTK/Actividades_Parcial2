using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TareaX2.Api.Infrastructure;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a 
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 2
Nombre del alumno: Lopez Canul Joatan de Jesus
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/
namespace TareaX2.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
     public class Alcohol : ControllerBase
    {
        [HttpGet]
        public string Fin (string bebida, double cantidad, double peso)
        {
            double Res;
            var repositorio = new OpAlco();
            Res = repositorio.Alcoholemia(bebida, cantidad, peso);
            if(Res <= 0.8)
            {
                return "No hay problema. Siga";
            }

            else
            {
                return "Que conduzca otro porfavor.";
            }
        }
    }
}

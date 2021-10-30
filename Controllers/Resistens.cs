using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TareaX2.Api.Domain;

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
    [Route("[controller]")]
    public class Resistens : ControllerBase
    {
        [HttpGet("CalcularResitencia")]
        public ActionResult<Resi> Resistencias (string CB1, string CB2, string CB3, string CB4)
        {
            Resi COL = new Resi();

                COL.Col_B = CB1;

                var T = "";

                switch (COL.Col_B)
            {
                case "Negro":
                COL.V1 = 0;
                break;
                case "Cafe":
                COL.V1 = 1;
                break;
                case "Rojo":
                COL.V1 = 2;
                break;
                case "Naranja":
                COL.V1 = 3;
                break;
                case "Amarrillo":
                COL.V1 = 4;
                break;
                case "Verde":
                COL.V1 = 5;
                break;
                case "Azul":
                COL.V1 = 6;
                break;
                case "Violeta":
                COL.V1 = 7;
                break;
                case "Gris":
                COL.V1 = 8;
                break;
                case "Blanco":
                COL.V1 = 9;
                break;
                default:
                T = $"Color '{CB1}' invalido. Ponga color correcto";
                return Ok(T);
            }

            var C1 = COL.V1;

            COL.Col_B = CB2;

            switch (COL.Col_B)
            {
                case "Negro":
                COL.V1 = 0;
                break;
                case "Cafe":
                COL.V1 = 1;
                break;
                case "Rojo":
                COL.V1 = 2;
                break;
                case "Naranja":
                COL.V1 = 3;
                break;
                case "Amarrillo":
                COL.V1 = 4;
                break;
                case "Verde":
                COL.V1 = 5;
                break;
                case "Azul":
                COL.V1 = 6;
                break;
                case "Violeta":
                COL.V1 = 7;
                break;
                case "Gris":
                COL.V1 = 8;
                break;
                case "Blanco":
                COL.V1 = 9;
                break;
                default:
                return Ok(T);
            }

            var C2 = COL.V1;

            COL.Col_B = CB3;

                switch (COL.Col_B)
            {
                case "Negro":
                COL.V2 = 1;
                break;
                case "Cafe":
                COL.V2 = 10;
                break;
                case "Rojo":
                COL.V2 = 100;
                break;
                case "Naranja":
                COL.V2 = 1000;
                break;
                case "Amarrillo":
                COL.V2 = 10000;
                break;
                case "Verde":
                COL.V2 = 100000;
                break;
                case "Azul":
                COL.V2 = 1000000;
                break;
                case "Dorado":
                COL.V2 = 10;
                break;
                case "Plateado":
                COL.V2 = 100;
                break;
                default:
                return Ok(T);
            }

            var C3 = COL.V2;

                COL.Col_B = CB4;

                switch (COL.Col_B)
            {

                case "Dorado":
                COL.V1 = 5;
                break;
                case "Plateado":
                COL.V1 = 10;
                break;
                default:
                return Ok(T);
            
            }

            var C4 = COL.V1;
            
            float Ter;

            var N1  = Int32.Parse($"{C1}{C2}");

            if (CB3 == "Dorado" || CB3 == "Plateado")
            {
                Ter = (N1 / C3);
            }
            else
            {
                Ter = (N1 * C3);
            }

            T = "Resultado: "+ Ter +" ohms y Resistencia tolerada: " + C4 + "%";

            return Ok(T);
        }
    }
}
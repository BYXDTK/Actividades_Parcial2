using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaX2.Api.Infrastructure
{
    public class OpAlco
    {
        public double Alcoholemia (string Beb, double Can, double kg)
        {
            double AlCon;
            double AlSan;
            double MGS;
            double LiSan;
            double AVS;
            double ml;
            double GA;

            switch (Beb)
            {
                case "Cerveza":
                    ml = 330 * Can;
                    GA = 5;
                    break;
                case "Vino":
                    ml = 100 * Can;
                    GA = 12;
                    break;
                case "Cava":
                    ml = 100 * Can;
                    GA = 12;
                    break;
                case "Vermu":
                    ml = 70 * Can;
                    GA = 17;
                    break;
                case "Licor":
                    ml = 45 * Can;
                    GA = 23;
                    break;
                case "Brandy":
                    ml = 45 * Can;
                    GA = 38;
                    break;
                case "Combinado":
                    ml = 45 * Can;
                    GA = 38;
                    break;
                default:
                    ml = 0;
                    GA = 0;
                    break;     
            }
            
            AlCon = (GA * 0.010) * ml;
            AlSan = 0.15 * AlCon;
            MGS = 0.789 * AlSan;
            LiSan = 0.08 * kg;
            AVS = MGS / LiSan;
            return AVS;   
        }
    }
}
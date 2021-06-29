using CONTROLES_VARIOS_DAL.Ecuaciones;
using System;
using System.Windows.Forms;

namespace CONTROLES_VARIOS_BLL.Ecuaciones
{
    public class Cls_Ecuaciones_BLL
    {

        #region Calculos

        public void CalculoEcuaciones(ref Cls_Ecuaciones_DAL obj_Ecuaciones_DAL)
        {
            // Calculo Discriminante
            obj_Ecuaciones_DAL.dDiscr = Math.Round((Math.Pow(obj_Ecuaciones_DAL.dNumbB, 2)) - (4 * obj_Ecuaciones_DAL.dNumbA * obj_Ecuaciones_DAL.dNumbC), 5);

            if (obj_Ecuaciones_DAL.dDiscr == 0)
            {
                obj_Ecuaciones_DAL.dSol_I = Math.Round(-(obj_Ecuaciones_DAL.dNumbB) / (2 * obj_Ecuaciones_DAL.dNumbA), 5) ;
                obj_Ecuaciones_DAL.dSol_II = obj_Ecuaciones_DAL.dSol_I;
            }
            else if (obj_Ecuaciones_DAL.dDiscr < 0)
            {
                obj_Ecuaciones_DAL.dSol_I = 0;
                obj_Ecuaciones_DAL.dSol_II = 0;

            }
            else if (obj_Ecuaciones_DAL.dDiscr > 0)
            {
                obj_Ecuaciones_DAL.dSol_I = Math.Round((-obj_Ecuaciones_DAL.dNumbB + Math.Sqrt(obj_Ecuaciones_DAL.dDiscr)) / (2 * obj_Ecuaciones_DAL.dNumbA),5);
                obj_Ecuaciones_DAL.dSol_II = Math.Round((-obj_Ecuaciones_DAL.dNumbB - Math.Sqrt(obj_Ecuaciones_DAL.dDiscr)) / (2 * obj_Ecuaciones_DAL.dNumbA),5);
            }

        }

        #endregion
    }
}

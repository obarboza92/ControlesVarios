using CONTROLES_VARIOS_DAL.Sumatoria;
using System;

namespace CONTROLES_VARIOS_BLL.Sumatoria
{
    public class Cls_Sumatoria_BLL
    {
        /// <summary>
        /// Nombre del Metodo = Sumatoria
        /// Funcionalidad = El metodo recibe 3 numeros correspondientes a enteros o decimales para obtener el discriminante y sus respectivas soluciones
        /// (ecuacion de segundo grado
        /// </summary>
        /// <param name="obj_Sumatoria_DAL"></param>
        public void Sumatoria(ref Cls_Sumatoria_DAL obj_Sumatoria_DAL)
        {
            obj_Sumatoria_DAL.uResulTotal = 0;
            obj_Sumatoria_DAL.uResulPares = 0;
            obj_Sumatoria_DAL.uResulImpares = 0;

            for (int i = 0; i <= obj_Sumatoria_DAL.uNum; i++)
            {
                obj_Sumatoria_DAL.uResulTotal = (ushort)(obj_Sumatoria_DAL.uResulTotal + Convert.ToUInt16(i));

                if((i % 2 )== 0)
                {
                    obj_Sumatoria_DAL.uResulPares = (ushort)(obj_Sumatoria_DAL.uResulPares + Convert.ToUInt16(i));
                }
                else
                {
                    obj_Sumatoria_DAL.uResulImpares = (ushort)(obj_Sumatoria_DAL.uResulImpares + Convert.ToUInt16(i));
                }
            }
        }
    }
}

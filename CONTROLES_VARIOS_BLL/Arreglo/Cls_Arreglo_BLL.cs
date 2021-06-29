using CONTROLES_VARIOS_DAL.Arreglo;
using System;
using System.Linq;

namespace CONTROLES_VARIOS_BLL.Arreglo
{
    public class Cls_Arreglo_BLL
    {
        byte[] ArregloRandom; // Deberia estar en DAL
        
        #region Calculos

        public void LlenadoArreglo(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            ArregloRandom = new byte[obj_Arreglo_DAL.uTamArreglo];

            Random randNum = new Random();

            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                ArregloRandom[i] = (byte)randNum.Next(obj_Arreglo_DAL.uLimRandom);
            }
        }
        public void MostrarArregloOriginal(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArregloOr = "";
            obj_Arreglo_DAL.sContArregloOr += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                obj_Arreglo_DAL.sContArregloOr += ArregloRandom[i];

                if (i != ArregloRandom.Length - 1)
                {
                    obj_Arreglo_DAL.sContArregloOr += " , ";
                }
            }
            obj_Arreglo_DAL.sContArregloOr += " }";
        }
        public void RemMenoresDiez(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if(ArregloRandom[i] >= 10)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }
        public void RemMayoresCincuenta(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] <= 50)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }
        public void RemoverParesArreglo(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] % 2 != 0)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }
        public void RemPar_Men(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] % 2 != 0 && ArregloRandom[i] > 10)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";

        }
        public void RemPar_May(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] % 2 != 0 && ArregloRandom[i] < 50)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }
        public void RemMen_May(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] > 10 && ArregloRandom[i] < 50)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }
        public void RemTodos(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.sContArrMod += "{ ";
            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                if (ArregloRandom[i] % 2 != 0 && ArregloRandom[i] > 10 && ArregloRandom[i] < 50)
                {
                    obj_Arreglo_DAL.sContArrMod += ArregloRandom[i];

                    if (i != ArregloRandom.Length - 1)
                    {
                        obj_Arreglo_DAL.sContArrMod += " , ";
                    }
                }
            }
            obj_Arreglo_DAL.sContArrMod += " }";
        }


        // Metodo nuevo
        //hacer arreglo en DAL 
        public void LlenarArreglo(ref Cls_Arreglo_DAL obj_Arreglo_DAL)
        {
            obj_Arreglo_DAL.RanNumeros = new Random();
            ArregloRandom = new byte[obj_Arreglo_DAL.uTamArreglo];

            for (int i = 0; i < obj_Arreglo_DAL.uTamArreglo; i++)
            {
               byte bNumero = Convert.ToByte(obj_Arreglo_DAL.RanNumeros.Next(1, obj_Arreglo_DAL.uLimRandom + 1));

                if (ArregloRandom.Contains(bNumero))
                {
                    i--;
                }
                else
                {
                    ArregloRandom[i] = bNumero;
                }

            }
        }
        #endregion
    }
}

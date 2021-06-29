using System;

namespace CONTROLES_VARIOS_DAL.Arreglo
{
    public class Cls_Arreglo_DAL
    {
        #region Declaracion de variables

        private ushort _uTamArreglo, _uLimRandom;
        private string _sContArregloOr, _sContArrMod;
        private Random _ranNumeros;

        #endregion

        #region Metodos


        public string sContArregloOr { get => _sContArregloOr; set => _sContArregloOr = value; }
        public string sContArrMod { get => _sContArrMod; set => _sContArrMod = value; }
        public ushort uTamArreglo { get => _uTamArreglo; set => _uTamArreglo = value; }
        public ushort uLimRandom { get => _uLimRandom; set => _uLimRandom = value; }
        public Random RanNumeros { get => _ranNumeros; set => _ranNumeros = value; }

        #endregion

    }
}

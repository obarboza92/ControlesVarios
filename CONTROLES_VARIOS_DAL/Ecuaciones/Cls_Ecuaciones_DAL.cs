namespace CONTROLES_VARIOS_DAL.Ecuaciones
{
    public class Cls_Ecuaciones_DAL
    {
        #region Definicion Variables

            private double _dNumbA, _dNumbB, _dNumbC, _dDiscr, _dSol_I, _dSol_II;

        #endregion

        #region Metodos o Constructores

            public double dNumbA { get => _dNumbA; set => _dNumbA = value; }
            public double dNumbB { get => _dNumbB; set => _dNumbB = value; }
            public double dNumbC { get => _dNumbC; set => _dNumbC = value; }
            public double dDiscr { get => _dDiscr; set => _dDiscr = value; }
            public double dSol_I { get => _dSol_I; set => _dSol_I = value; }
            public double dSol_II { get => _dSol_II; set => _dSol_II = value; }

        #endregion
    }
}

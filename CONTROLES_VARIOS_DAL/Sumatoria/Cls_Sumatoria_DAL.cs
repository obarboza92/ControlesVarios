using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLES_VARIOS_DAL.Sumatoria
{
    public class Cls_Sumatoria_DAL
    {
        #region Declaracion de variables

        private ushort _uNum, _uResulTotal, _uResulPares, _uResulImpares;

        #endregion

        #region Metodos

        public ushort uNum { get => _uNum; set => _uNum = value; }
        public ushort uResulTotal { get => _uResulTotal; set => _uResulTotal = value; }
        public ushort uResulPares { get => _uResulPares; set => _uResulPares = value; }
        public ushort uResulImpares { get => _uResulImpares; set => _uResulImpares = value; }


        #endregion

    }
}

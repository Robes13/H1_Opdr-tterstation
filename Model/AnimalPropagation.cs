using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    /// <summary>
    /// This class is animal Proppagation.
    /// </summary>
    internal class AnimalPropagation
    {
        #region Fields
        private string _propagation;
        #endregion Fields
        #region Propeties
        internal string Propagation
        {
            get { return _propagation; }
            set { _propagation = value; }
        }
        #endregion Properties
    }
}

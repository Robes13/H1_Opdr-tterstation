using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    /// <summary>
    /// This class is animal fur.
    /// </summary>
    internal class AnimalFur
    {
        #region Fields
        private string? _furType;
        #endregion Fields
        #region Constructors
        internal AnimalFur(string? furType)
        {
            _furType = furType;
        }
        #endregion Constructors
        #region Properties
        internal string FurType
        {
            get { return _furType; }
            set { _furType = value; }
        }
        #endregion Properties
    }
}

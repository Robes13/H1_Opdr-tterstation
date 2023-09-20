using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    /// <summary>
    /// This class is the animals gender.
    /// </summary>
    internal class AnimalSex
    {
        #region Fields
        private string _sex;
        #endregion Fields
        #region Constructors
        internal AnimalSex(string sex)
        {
            _sex = sex;
        }
        #endregion Constructors
        #region Properties
        internal string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        #endregion Properties
    }
}

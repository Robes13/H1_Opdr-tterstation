using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    /// <summary>
    /// Here we define what an animal is.
    /// </summary>
    internal abstract class Animal
    {
        #region Fields
        private protected string _type;
        private protected AnimalSex _sex;
        private protected AnimalPropagation _propagation;
        private protected byte? _legs;
        private protected AnimalFur? _furType;
        private protected byte _age;
        #endregion Fields
        #region Properties
        private protected string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private protected AnimalSex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private protected AnimalPropagation Propagation
        {
            get { return _propagation; }
            set { _propagation = value; }
        }
        private protected byte? Legs
        {
            get { return _legs; }
            set { _legs = value; }
        }
        private protected AnimalFur FurType
        {
            get { return _furType; }
            set { _furType = value; }
        }
        private protected byte Age
        {
            get { return _age; }
            set { _age = value; }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Here we are telling the program that every class that is inheriated from this class, need to implement this method.
        /// </summary>
        /// <returns></returns>
        internal abstract string Print();
        #endregion Methods
    }
}

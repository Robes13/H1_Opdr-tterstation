using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model.Created_Animals
{
    /// <summary>
    /// This class is a chicken, and therefore a bird species.
    /// </summary>
    internal class Chicken : Animal
    {
        public Chicken(AnimalSex sex, byte legs, AnimalFur furType, byte age)
        {
            AnimalPropagation propagation = new AnimalPropagation();
            propagation.Propagation = "Bird";
            _type = "Chicken";
            _sex = sex;
            _propagation = propagation;
            _legs = legs;
            _furType = furType;
            Age = age;
        }
        /// <summary>
        /// Creating the string for this object.
        /// </summary>
        /// <returns></returns>
        internal override string Print()
        {
            return $"I have {_legs}! And I am a Chicken";
        }
    }
}

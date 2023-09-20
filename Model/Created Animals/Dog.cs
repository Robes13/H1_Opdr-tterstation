using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model.Created_Animals
{
    /// <summary>
    /// This class is a dog and therefore a mamal.
    /// </summary>
    internal class Dog : Animal
    {
        public Dog(AnimalSex sex, byte legs, AnimalFur furType, byte age) 
        {
            AnimalPropagation propagation = new AnimalPropagation();
            propagation.Propagation = "Mamal";
            _type = "Dog";
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
            return $"I have {_legs}! And I am a dog";
        }
    }
}

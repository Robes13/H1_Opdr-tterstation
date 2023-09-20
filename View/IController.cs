using Opdrætterstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.View
{
    /// <summary>
    /// New interface.
    /// </summary>
    internal interface IController
    {
        // Every class using this interace needs to implement this method.
        public void PrintList(List<Animal> animals);
        
    }
}

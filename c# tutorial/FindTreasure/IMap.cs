using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial.FindTreasure
{
    public interface IMap
    {
        void DisplayMap();
        T HideTheTreasure<T>(int numberOfTreasure);
        void FindTheTreasure<T>(T HiddenTreasures);
        void InitializeMap();


    }
}

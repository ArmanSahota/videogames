using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogames
{
    internal class Apple_Orchard
    {
        string _orchardName;
        int _numberOfApples;
    

        public string OrchardName
        {
            get { return _orchardName; }
            set { _orchardName = value; }
        }

        public int NumberOfApples
        {
            get { return _numberOfApples; }
            set { _numberOfApples = value; }
        }

        public void PickApples(int numberOfApples)
        {
            if (numberOfApples > 0)
            {
                _numberOfApples += numberOfApples;
            }
        }

        public void SellApples(int numberOfApples)
        {
            if (numberOfApples > 0 && numberOfApples <= _numberOfApples)
            {
                _numberOfApples -= numberOfApples;
            }
        }

        public Apple_Orchard(string orchardName, int numberOfApples)
        {
            _orchardName = orchardName;
            _numberOfApples = numberOfApples;
        }

        public override string ToString()
        {
            return $"{_orchardName} - Number of Apples: {_numberOfApples}";
        }
    }
}

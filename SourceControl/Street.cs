using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Street
    {
        private int _StreetID;
        private string _StreetName;

        public Street()
        {

        }

        public Street(string streetName)
        {
            StreetName = streetName;
        }

        public int StreetID
        {
            get
            {
                return _StreetID;
            }
            set
            {
                _StreetID = value;
            }
        }

        public string StreetName
        {
            get
            {
                return _StreetName;
            }
            set
            {
                _StreetName = value;
            }
        }

        public override string ToString()
        {
            return _StreetName;
        }
    }
}

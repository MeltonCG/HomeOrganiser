using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOrganiser.Core.Attributes
{
    public class DisplayDescription : Attribute
    {
        public string NameToShow { get; set; }

        public DisplayDescription(string _nameToShow)
        {
            NameToShow = _nameToShow;
        }
    }
}

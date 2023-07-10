using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.ValueObject
{
    public class DeckDetails
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public DeckDetails()
        {

        }
        public DeckDetails(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

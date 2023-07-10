using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    internal interface IDeck
    {
        Guid Id { get; }
        IEquatable<IDecKCardDefinition> Cards { get; }
    }
}

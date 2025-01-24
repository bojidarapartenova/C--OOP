using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public interface IRemove
    {
        ICollection<string> Collection { get; }
        string Remove();
    }
}

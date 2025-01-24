using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        public AddCollection()
        {
            Collection = new List<string>();
        }

        public ICollection<string> Collection {get; private set;}

        public int Add(string element)
        {
            Collection.Add(element);
            return Collection.Count-1;
        }
    }
}

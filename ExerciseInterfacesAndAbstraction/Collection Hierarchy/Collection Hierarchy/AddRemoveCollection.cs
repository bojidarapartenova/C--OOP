namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAdd, IRemove
    {
        public AddRemoveCollection()
        {
            Collection = new List<string>();
        }

        public ICollection<string> Collection { get; private set; }

        public int Add(string element)
        {
            ((List<string>)Collection).Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string lastItem = Collection.Last();
            ((List<string>)Collection).RemoveAt(Collection.Count - 1);

            return lastItem;
        }
    }
}

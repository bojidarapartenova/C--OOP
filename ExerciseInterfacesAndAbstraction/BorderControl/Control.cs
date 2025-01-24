namespace BorderControl
{
    public class Control
    {
        private List<Identity> _identities;

        public Control()
        {
            _identities = new List<Identity>();
        }

        public List<Identity> Identities => _identities;

        public void AddIdentity(Identity identity)
        {
            _identities.Add(identity);
        }
    }
}

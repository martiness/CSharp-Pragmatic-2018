namespace MyWalletProject02
{
    public abstract class EntityBase
    {
        private string _description = string.Empty;

        private double _amount = 0;

        public string Desription { get { return _description; } set { _description = value; } }

        public double Amount { get { return _amount; } set { _amount = value; } }
    }
}
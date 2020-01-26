namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}

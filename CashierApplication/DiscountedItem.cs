namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount;
            discounted_price = 0.0;
            payment_amount = 0.0;
            change = 0.0;
        }

        public override double getTotalPrice()
        {
            discounted_price = item_price * (1 - item_discount * 0.01);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - total_price;
        }

        public double getChange()
        {
            return change;
        }
    }
}

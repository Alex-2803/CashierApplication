namespace ItemNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
            total_price = 0.0;
        }

        public abstract double getTotalPrice();

        public void setPayment(double amount)
        {
            // Implement this method in DiscountedItem
        }
    }
}

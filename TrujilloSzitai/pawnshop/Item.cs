namespace pawnshop {
    class Item {
        string name = "";
        double price = 0;
        bool isOnSale = false;
        Condition condition = Condition.REGULAR;
        Category category = Category.VALUABLE;

        public string Name => name;
        public double Price => price;
        public bool IsOnSale => isOnSale;

        public Item() {

        }
        public Item(string name, double price, bool isOnSale, Condition condition, Category category) {
            this.name = name;
            this.price = price;
            this.isOnSale = isOnSale;
            this.condition = condition;
            this.category = category;
        }
    }
}
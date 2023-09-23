namespace pawnshop {
    class Item {
        string name;
        double price;
        bool isOnSale;
        Condition condition;
        Category category;

        public string Name => name;
        public double Price => price;
        public bool IsOnSale => isOnSale;
        public Condition Condition => condition;
        public Category Category => category;


        public Item(string name, double price, bool isOnSale, Condition condition, Category category) {
            this.name = name;
            this.price = price;
            this.isOnSale = isOnSale;
            this.condition = condition;
            this.category = category;
        }
    }
}
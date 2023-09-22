namespace steam {
    class User {
        string name;
        int age;
        double balance;
        List<Product> purchasedProducts = new List<Product>();

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }
        public List<Product> PurchasedProducts
        {
            get => purchasedProducts;
            set => purchasedProducts = value;
        }

        public User(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public User(string name, int age, double balance) {
            this.name = name;
            this.age = age;
            this.balance = balance;
        }
        public User(string name, int age, double balance, List<Product> products) {
            this.name = name;
            this.age = age;
            this.balance = balance;
            this.purchasedProducts = products;
        }
    }
}
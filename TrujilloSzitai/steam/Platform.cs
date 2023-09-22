namespace steam {
    class Platform {
        string name;
        List<Product> products = new List<Product>();
        List<User> users = new List<User>();
        
        public string Name
                {
            get => name;
            set => name = value;
        }
        public List<Product> Products
        {
            get => products;
            set => products = value;
        }
        public List<User> Users
        {
            get => users;
            set => users = value;
        }

        public Platform(string name) {
            this.name = name;
        }
        public Platform(string name, List<Product> products) {
            this.name = name;
            this.products = products;
        }
        public Platform(string name, List<Product> products, List<User> users) {
            this.name = name;
            this.products = products;
            this.users = users;
        }
    }
}
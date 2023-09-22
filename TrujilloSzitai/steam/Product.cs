namespace steam
{
    class Product
    {
        protected string name;
        protected double price;
        protected bool earlyAccess;
        protected double score;
        protected List<Review> reviews = new List<Review>();

        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public bool EarlyAccess
        {
            get => earlyAccess;
            set => earlyAccess = value;
        }
        public double Score
        {
            get => score;
            set => score = value;
        }
        public List<Review> Reviews
        {
            get => reviews;
            set => reviews = value;
        }

        public Product(string name, double price, bool earlyAccess)
        {
            this.name = name;
            this.price = price;
            this.earlyAccess = earlyAccess;
        }
        public Product(string name, double price, bool earlyAccess, double score)
        {
            this.name = name;
            this.price = price;
            this.earlyAccess = earlyAccess;
            this.score = score;
        }
        public Product(string name, double price, bool earlyAccess, double score, List<Review> reviews)
        {
            this.name = name;
            this.price = price;
            this.earlyAccess = earlyAccess;
            this.score = score;
            this.reviews = reviews;
        }
    }
}
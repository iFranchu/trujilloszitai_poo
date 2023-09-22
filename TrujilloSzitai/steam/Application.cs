namespace steam {
    class Application : Product
    {
        SoftwareCategory category;

        public SoftwareCategory Category
        {
            get => category;
            set => category = value;
        }

        public Application(string name, double price, bool earlyAccess, double score, SoftwareCategory category) : base(name, price, earlyAccess, score) {
            this.category = category;
        }
        
        public Application(string name, double price, bool earlyAccess, double score, List<Review> reviews, SoftwareCategory category) : base(name, price, earlyAccess, score, reviews) {
            this.category = category;
        }

        public override string ToString() {
            return $"La aplicación {name} cuesta ${price}, pertenece a la categoría {category} y tiene una puntuación de {score} puntos. Cuenta con {reviews.Count} reseña(s).";
        }
    }
}
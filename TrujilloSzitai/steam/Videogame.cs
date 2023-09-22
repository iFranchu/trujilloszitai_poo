namespace steam
{
    class Videogame : Product
    {
        int minimumAge;
        VideogameCategory category;

        public int MinimumAge
        {
            get => minimumAge;
            set => minimumAge = value;
        }

        public VideogameCategory Category
        {
            get => category;
            set => category = value;
        }

        public Videogame(string name, double price, bool earlyAccess, double score, int minimumAge, VideogameCategory category) : base(name, price, earlyAccess, score)
        {
            this.minimumAge = minimumAge;
            this.category = category;
        }
        public Videogame(string name, double price, bool earlyAccess, int minimumAge, VideogameCategory category) : base(name, price, earlyAccess)
        {
            this.minimumAge = minimumAge;
            this.category = category;
        }

        public Videogame(string name, double price, bool earlyAccess, double score, List<Review> reviews, int minimumAge, VideogameCategory category) : base(name, price, earlyAccess, score, reviews)
        {
            this.minimumAge = minimumAge;
            this.category = category;
        }

        public override string ToString() {
            string earlyAccessMsg = earlyAccess ? "Se encuentra en acceso anticipado" : "No se encuentra en acceso anticipado";
            return $"El videojuego {name} cuesta ${price}, pertenece a la categoría {category} y tiene una puntuación de {score} puntos. Cuenta con {reviews.Count} reseña(s). Su edad mínima de acceso es de {minimumAge} años. {earlyAccessMsg}.";
        }
    }
}
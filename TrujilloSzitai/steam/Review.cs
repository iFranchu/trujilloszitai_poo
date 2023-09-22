namespace steam {
    class Review {
        string title;
        string content;
        User author;
        bool isPositive;
        Date date;

        public string Title 
        {
            get => title;
            set => title = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
        public User Author => author;
        public bool IsPositive
        {
            get => isPositive;
            set => isPositive = value;
        }
        public Date Date => date;

        public Review(string title, string content, User author, bool isPositive, Date date) {
            this.title = title;
            this.content = content;
            this.author = author;
            this.isPositive = isPositive;
            this.date = date;
        }
    }
}
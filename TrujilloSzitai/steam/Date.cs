namespace steam {
    class Date {
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Month;

        public int Day => day;
        public int Month => month;
        public int Year => year;

        public Date() {

        }

        public Date(int day, int month, int year) {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
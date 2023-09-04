namespace footballClub {
    class Address {
        string _street = "";
        string _height = "";
        string _city = "";

        public string street => _street;
        public string height => _height;
        public string city => _city;

        public Address() {

        }
        public Address(string street, string height, string city) {
            _street = street;
            _height = height;
            _city = city;
        }
    }
}
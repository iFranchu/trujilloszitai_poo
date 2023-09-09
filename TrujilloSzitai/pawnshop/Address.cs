namespace pawnshop {
    class Address {
        string street = "";
        string height = "";
        string zipCode = "";

        public string Street => street;
        public string Height => height;
        public string ZipCode => zipCode;

        public Address() {
            
        }
        public Address(string street, string height, string zipCode) {
            this.street = street;
            this.height = height;
            this.zipCode = zipCode;
        }
    }
}
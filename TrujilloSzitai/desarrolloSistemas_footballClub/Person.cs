namespace footballClub {
    abstract class Person {
        protected string _firstName = "";
        protected string _lastName = "";
        public string firstName => _firstName;
        public string lastName => _lastName;

        public abstract string Present();
    }
}
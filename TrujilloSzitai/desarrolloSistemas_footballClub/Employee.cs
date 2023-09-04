using System.Runtime.CompilerServices;

namespace footballClub {
    class Employee : Person {
        string _function = "";
        public string function => _function;

        public Employee() {

        }
        
        public Employee(string fName, string lName, string function) {
            _firstName = fName;
            _lastName = lName;
            _function = function;
        }

        public override string Present() {
            return $"Hi! I am an employee. My name is {firstName} {lastName}, and my function is: {function}.";
        }
    }
}
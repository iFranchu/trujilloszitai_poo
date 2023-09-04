namespace footballClub {
    class Player : Person {
        int _playerNumber = 0;
        public int playerNumber => _playerNumber;

        public Player() {

        }
        public Player(string fName, string lName, int number) {
            _firstName = fName;
            _lastName = lName;
            _playerNumber = number;
        }
        
        public override string Present() {
            return $"Hi! I am a football player. My name is {firstName} {lastName}, and I have the number {playerNumber}.";
        }
    }
}
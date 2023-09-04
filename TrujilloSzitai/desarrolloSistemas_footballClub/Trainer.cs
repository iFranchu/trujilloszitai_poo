namespace footballClub
{
    class Trainer : Person
    {
        Tactic _tactic;
        public Tactic tactic => _tactic;

        public Trainer()
        {

        }
        public Trainer(string fName, string lName, Tactic tactic)
        {
            _firstName = fName;
            _lastName = lName;
            _tactic = tactic;
        }
        
        public override string Present()
        {
            return $"Hi! I am a football trainer. My name is {firstName} {lastName}, and my tactic is {tactic}.";
        }
    }
}
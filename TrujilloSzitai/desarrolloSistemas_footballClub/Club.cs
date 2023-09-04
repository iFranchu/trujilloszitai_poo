namespace footballClub
{
    class Club
    {
        string _name = "";
        int _foundationYear = 0;
        Address _address = new Address();
        List<Team> _teams = new List<Team>();
        List<Employee> _employees = new List<Employee>();
        public string name => _name;
        public int foundationYear => _foundationYear;
        public Address address => _address;
        public List<Team> teams => _teams;
        public List<Employee> employees => _employees;

        public Club()
        {

        }
        public Club(string name, int foundationYear, Address address, List<Team> teams, List<Employee> employees)
        {
            _name = name;
            _foundationYear = foundationYear;
            _address = address;
            _teams = teams;
            _employees = employees;
        }

        /// <summary>
        /// Add a <c>Team</c> to the club teams list
        /// </summary>
        /// <param name="team">The <c>Team</c> that will be added</param>
        public void AddTeam(Team team)
        {
            if (_teams.Find(e => e == team) is not null) _teams.Add(team);
        }

        /// <summary>
        /// Remove the specified <c>Team</c> from the club teams list
        /// </summary>
        /// <param name="team">The <c>Team</c> that will be removed</param>
        public void DeleteTeam(Team team)
        {
            Team? selectTeam = _teams.Find(e => e == team);

            if (selectTeam is not null) _teams.Remove(selectTeam);
        }

        /// <summary>
        /// Add a <c>Employee</c> to the club employees list
        /// </summary>
        /// <param name="employee">The <c>Employe</c> that will be added</param>
        public void AddEmployee(Employee employee)
        {
            if (_employees.Find(e => e == employee) is not null) _employees.Add(employee);
        }

        /// <summary>
        /// Remove the specified <c>Employee</c> from the club employees list
        /// </summary>
        /// <param name="employee">The <c>Employee</c> that will be removed</param>
        public void DeleteEmployee(Employee employee)
        {
            Employee? selectEmployee = _employees.Find(e => e == employee);

            if (selectEmployee is not null) _employees.Remove(selectEmployee);
        }
    }
}
namespace footballClub
{
    class Team
    {
        List<Player> _players = new List<Player>();
        Trainer _trainer = new Trainer();
        TeamCategory _category = TeamCategory.PRIMERA;
        public List<Player> players => _players;
        public Trainer trainer => _trainer;
        public TeamCategory category => _category;

        public Team()
        {

        }
        public Team(List<Player> players, Trainer trainer, TeamCategory category)
        {
            _players = players;
            _trainer = trainer;
            _category = category;
        }

        /// <summary>
        /// Add a <c>Player</c> to the team players list
        /// </summary>
        /// <param name="player">The <c>Player</c> that will be added</param>
        public void AddPlayer(Player player)
        {
            if (_players.Find(e => e.playerNumber == player.playerNumber) is null) _players.Add(player);
        }

        /// <summary>
        /// Remove the specified <c>Player</c> from the team players list
        /// </summary>
        /// <param name="player">The <c>Player</c> that will be removed</param>
        public void DeletePlayer(Player player)
        {
            Player? selectPlayer = _players.Find(e => e == player);

            if (selectPlayer is not null) _players.Remove(selectPlayer);
        }
    }
}
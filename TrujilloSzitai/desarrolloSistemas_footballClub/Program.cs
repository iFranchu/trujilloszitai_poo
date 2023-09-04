using System;
using System.Threading;

namespace footballClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Club myClub;
            Address fakeAddress = new Address("Acá", "1144", "Allá");
            List<Team> myTeams = new List<Team>();
            List<Employee> myEmployees = new List<Employee>();

            Console.WriteLine("CARGANDO BASE DE DATOS MUNDIAL DE CLUBES...");
            Thread.Sleep(5000);
            
            for (int i = 1; i <= 3; i++)
            {
                List<Player> myPlayers = new List<Player>();

                Trainer myTrainer = new Trainer($"trainerName{i}", $"trainerSurname{i}", (Tactic)(i - 1));
                TeamCategory myCategory = (TeamCategory)(i - 1);
                for (int j = 1; j <= 11; j++)
                {
                    string genericFirstName = $"firstName{j}";
                    string genericLastname = $"lastName{j}";

                    Player player = new Player(genericFirstName, genericLastname, j);
                    Employee employee = new Employee(genericFirstName, genericLastname, $"function{i}");

                    myPlayers.Add(player);
                    myEmployees.Add(employee);
                }

                Team newTeam = new Team(myPlayers, myTrainer, myCategory);
                myTeams.Add(newTeam);
            }

            myClub = new Club("FARMACITY", DateTime.Now.Year, fakeAddress, myTeams, myEmployees);

            Console.WriteLine($"BUSCANDO DATOS DEL CLUB {myClub.name}...");
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine($"EL CLUB {myClub.name} TIENE {myClub.teams.Count} EQUIPOS Y {myClub.employees.Count} EMPLEADOS");
            Console.WriteLine();

            foreach (Team t in myClub.teams)
            {
                Console.WriteLine($"EL EQUIPO EN {t.category} DIVISIÓN A CARGO DEL ENTRENADOR {t.trainer.firstName} {t.trainer.lastName} TIENE {t.players.Count} JUGADORES Y UNA TÁCTICA {t.trainer.tactic}");
            }

            Console.ReadKey();
        }
    }
}
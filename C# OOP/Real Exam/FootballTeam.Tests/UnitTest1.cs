using NUnit.Framework;
using System;

namespace FootballTeam.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetConstructorWithValidData()
        {
            FootballTeam team = new FootballTeam("Milan", 15);

            Assert.IsNotNull(team);

        }

        [Test]
        public void PropertyNameSetWithValidData()
        {
            FootballTeam team = new FootballTeam("Milan", 20);
            string expected = "Milan";

            Assert.AreEqual(expected, team.Name);


        }

        [Test]
        public void PropertyNameSetWithInvalidDataThrowsException()
        {

            Assert.Throws<ArgumentException>(() => new FootballTeam("", 18), "Name cannot be null or empty!");
        }
        [Test]
        public void PropertyCapacityWithValidData()
        {

            FootballTeam team = new FootballTeam("Milan", 20);
            int expected = 20;

            Assert.AreEqual(expected, team.Capacity);
        }

        [Test]
        public void PropertyCapacitySetWithInvalidDataThrowsException()
        {

            Assert.Throws<ArgumentException>(() => new FootballTeam("Liverpool", 12), "Capacity min value = 15");
        }

        [Test]
        public void PropertyPlayersIsInitiliazedViaConstructor()
        {
            FootballTeam team = new FootballTeam("Milan", 20);
            Assert.IsNotNull(team.Players);
        }

        [Test]
        public void AddNewPlayerSuccesfully()
        {
            FootballTeam team = new FootballTeam("Milan", 20);

            FootballPlayer player = new FootballPlayer("Gosho", 9, "Midfielder");

            team.AddNewPlayer(player);

            Assert.AreEqual(1, team.Players.Count);

        }

        [Test]
        public void AddNewPlayerSuccesfullyReturnCorrectString()
        {
            FootballTeam team = new FootballTeam("Milan", 20);

            FootballPlayer player = new FootballPlayer("Gosho", 9, "Midfielder");

            team.Players.Add(player);
            string expected = $"Added player Gosho in position Midfielder with number 9";
            
            string actual = team.AddNewPlayer(player);
            Assert.AreEqual(expected, actual);
           

        }

        [Test]
        public void AddNewPlayerUnSuccesfullDueToLowCapacity()
        {
            FootballTeam team = new FootballTeam("Milan", 15);

            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            team.AddNewPlayer(new FootballPlayer("Mitaka", 10, "Goalkeeper"));   // unsuccesfull adding

            int exptected = 15;

            Assert.AreEqual(exptected, team.Players.Count);

        }
        [Test]
        public void AddNewPlayerUnSuccesfullDueToLowCapacityReturnCorrectString()
        {
            FootballTeam team = new FootballTeam("Milan", 15);

            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
                new FootballPlayer("Gosho",9,"Midfielder"),
            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            var lastPlayer = new FootballPlayer("Mitaka", 10, "Goalkeeper");   // unsuccesfull adding

            string expectedOutput = "No more positions available!";
            string actualOutput = team.AddNewPlayer(lastPlayer);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [Test]
        public void PickUpMethodReturnValidPlayer()
        {
            FootballTeam team = new FootballTeam("Milan", 15);
            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Mitko",1,"Midfielder"),
               
               
            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            var currentPlayer = team.PickPlayer("Mitko");
            Assert.IsNotNull(currentPlayer);
        }

        [Test]
        public void PickUpMethodReturnNullWithInValidPlayer()
        {
            FootballTeam team = new FootballTeam("Milan", 15);
            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Mitko",1,"Midfielder"),


            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            var currentPlayer = team.PickPlayer("Atanas");
            Assert.IsNull(currentPlayer);
        }

        [Test]
        public void PlayersScoreWithValidPlayerNumber()
        {
            FootballTeam team = new FootballTeam("Milan", 15);
            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Mitko",1,"Midfielder"),


            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            var currentPlayer = team.PlayerScore(9);

            Assert.IsNotNull(currentPlayer);
        }

        [Test]
        public void PlayersScoreWithValidPlayerNumberReturnCorrectString()
        {
            FootballTeam team = new FootballTeam("Milan", 15);
            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Mitko",1,"Midfielder"),


            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            var actualOutput = team.PlayerScore(9);

            string expectedMessage = "Gosho scored and now has 1 for this season!";

            Assert.AreEqual(expectedMessage,actualOutput);
        }

        [Test]
        public void PlayersScoreWithUnValidPlayerNumber()
        {
            FootballTeam team = new FootballTeam("Milan", 15);
            var playersToAdd = new FootballPlayer[]
            {
                new FootballPlayer("Gosho",9,"Goalkeeper"),
                new FootballPlayer("Mitko",1,"Midfielder"),


            };

            foreach (var item in playersToAdd)
            {
                team.AddNewPlayer(item);
            }

            //var currentPlayer = team.PlayerScore(10);

            Assert.Throws<NullReferenceException>(() => team.PlayerScore(10));
        }
    }
}
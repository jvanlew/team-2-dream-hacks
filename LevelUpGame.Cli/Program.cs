using LevelUpGame.Cli.Enumerations;
using LevelUpGame.Library.Entities;
using LevelUpGame.Library.Enumerations;
using LevelUpGame.Library.Infrastructure;
using Sharprompt;

namespace LevelUpGame.Cli
{
	internal class Program
	{

		private static readonly GameController _gameController;

		private static bool _isGameStarted;

		private static List<GameStatus> GameHistory { get; set; }


		static Program() {		
			_gameController = new GameController();
			_isGameStarted = false;
			GameHistory = new List<GameStatus>();
		}

		static void Main(string[] args) {

			Console.Clear();

			PrintWelcomeMessage();

			while (!_isGameStarted) {
				var type = Prompt.Select<StartMenuCommands>("Choose game command:");

				switch (type) {
					case StartMenuCommands.Help:
						Help();
						break;
					case StartMenuCommands.CreateCharacter:
						CreateCharacter();
						break;
					case StartMenuCommands.Exit:
						EndGame();
						break;
					case StartMenuCommands.StartGame:
						StartGame();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}

			while (true) {
				var type = Prompt.Select<InGameCommands>("Choose game command:");

				switch (type) {
					case InGameCommands.Help:
						Help();
						break;
					case InGameCommands.Exit:
						EndGame();
						break;
					case InGameCommands.North:
						MoveNorth();
						break;
					case InGameCommands.South:
						MoveSouth();
						break;
					case InGameCommands.East:
						MoveEast();
						break;
					case InGameCommands.West:
						MoveWest();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}


		}

		private static void PrintWelcomeMessage() {
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("LEVEL UP GAMES");
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("Use your arrow keys to select a command below");
			Console.WriteLine("Create a character with a custom name.");
			Console.WriteLine("Then, start the game to start your adventure.");
			Console.WriteLine("-------------------------------------------------");
		}

		static void Help() {
			//TODO: FILL OUT USER HELP INSTRUCTIONS
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("HELP!");
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("Choose a command below using your arrow keys.");
			Console.WriteLine("Once a game is started, you will be able to move and explore.");
			Console.WriteLine("Once you are done exploring, choose Exit to see a summary.");
			Console.WriteLine("-------------------------------------------------");
		}

		static void CreateCharacter() {
			var characterName = Prompt.Input<string>("What is your character's name?");
			_gameController.CreateCharacter(characterName);
			var gameStatusCharacterName = _gameController.GetStatus().CurrentCharacter.Name;
			Console.WriteLine($"Your character, {gameStatusCharacterName}, is created!");
		}

		static void StartGame() {
			_isGameStarted = true;
			_gameController.StartGame();
			// TODO: Update this prompt. Also, do you want to get the game status and tell
			// the character where their character is?
			Console.WriteLine("Welcome to Forests and Monsters! You have entered a mysterious place.");
		}

		static void MoveNorth() {
			_gameController.Move(MoveDirections.North);
			UpdateStatus(_gameController.GetStatus());
		}

		static void MoveSouth() {
			_gameController.Move(MoveDirections.South);
			UpdateStatus(_gameController.GetStatus());
		}

		static void MoveEast() {
			_gameController.Move(MoveDirections.East);
			UpdateStatus(_gameController.GetStatus());
		}

		static void MoveWest() {
			_gameController.Move(MoveDirections.West);
			UpdateStatus(_gameController.GetStatus());
		}

		static void EndGame() {
			var answer = Prompt.Confirm("Do you want to exit?");
			if (answer == true) {
				//TODO: PRINT FINAL SUMMARY
				Console.WriteLine("You exit the mysterious world.");
				PrintSummary();
				Environment.Exit(0);
			}
		}

		static void PrintSummary() {
			Console.WriteLine("Exiting the mysterious land!");
			foreach (GameStatus status in GameHistory) {
				// TODO: Override toString on game status to print pretty
				Console.WriteLine(status);
			}
			// TODO: Print anything else you committed to in your mockup

		}

		private static void UpdateStatus(GameStatus status) {
			GameHistory.Add(status.Clone());
		}
	}
}
using System.Drawing;

namespace LevelUpGame.Library.Entities
{
	public class Character
	{
		private const string DEFAULT_CHARACTER_NAME = "Default Character";

		public string Name { get; set; }

		public Character() : this(DEFAULT_CHARACTER_NAME) { }

		public Character(string name) {
			if (string.IsNullOrEmpty(name)) {
				name = DEFAULT_CHARACTER_NAME;
			}
			this.Name = name;
		}
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpGame.Cli.Enumerations
{
	public enum StartMenuCommands
	{
		[Description("Help")]
		Help,

		[Description("Create Character")]
		CreateCharacter,

		[Description("Start Game")]
		StartGame,

		[Description("Exit")]
		Exit
	}
}

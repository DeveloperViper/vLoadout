using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace server
{
	public class Main : BaseScript
	{
		[Command("loadout")]
		public void LoadoutCommand(int source, List<object> args, string raw)
		{
			var player = Players[source];
			// true
			if (IsPlayerAceAllowed(source.ToString(),"Viper.loadout"))
			{
				TriggerClientEvent(player, "chat:addMessage", new
				{
					color = new[] { 255, 0, 0 },
					multiline = true,
					args = new[] {"^3You have now have your loadout!" }
				});

				TriggerClientEvent(player, "loadout");
			}
			// false
			else
			{
				TriggerClientEvent(player, "chat:addMessage", new
				{
					color = new[] { 255, 0, 0 },
					multiline = true,
					args = new[] {"^8You do not have permission for this command"}
				});


			}
		}
	}
}

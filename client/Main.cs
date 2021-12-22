using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public class Main : BaseScript //
    {
        [Command("clearwp")]
        public void ClearwpCommand(int source, List<object> args, string raw) 
        {
            TriggerEvent("chat:addMessage", new
            {
                color = new[] { 255, 0, 0 },
                multiline = true,
                args = new[] { "^8Your Weapons Have Been Cleared!" }
            });

            RemoveAllPedWeapons(PlayerPedId(), false); 
        }
        

        [EventHandler("loadout")] 
        public void LoadoutCommand(int source, List<object> args, string raw) 
        {
            var ped = PlayerPedId();
            RemoveAllPedWeapons(ped, false);
            GiveWeaponToPed(ped, (uint)GetHashKey("weapon_combatpistol"), 100, false, false);
            GiveWeaponToPed(ped, (uint)GetHashKey("weapon_pumpshotgun"), 100, false, false);
            GiveWeaponToPed(ped, (uint)GetHashKey("weapon_carbinerifle"), 100, false, false);
            GiveWeaponToPed(ped, (uint)GetHashKey("weapon_stungun"), 100, false, false);
            GiveWeaponToPed(ped, (uint)GetHashKey("weapon_nightstick"), 100, false, false);
        } 
    }
}

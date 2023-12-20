﻿using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Utils;

namespace RetakesPlugin.Modules.Handlers;

public abstract class Weapons
{
    public static void Allocate(CCSPlayerController player)
    {
        // Weapon allocation logic
        if (player.TeamNum == (byte)CsTeam.Terrorist)
        {
            player.GiveNamedItem("weapon_ak47");
            player.GiveNamedItem("weapon_glock");
        }
        
        if (player.TeamNum == (byte)CsTeam.CounterTerrorist)
        {
            player.GiveNamedItem("weapon_m4a1");
            player.GiveNamedItem("weapon_usp");
        }
    }
}
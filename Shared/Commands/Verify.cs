﻿using System.Threading.Tasks;
using static Shared.Database;
using static Shared.Main;

namespace Shared.Commands
{
    public static class Verify
    {
        public static async Task<string> VerifyAll(Platform platform, ulong id, string key)
        {
            if (await Verify(platform, key, id)) 
                return $"Successfully linked your {platform} to SpookVooper account {await GetSVID(platform, id)}";
            return $"Failed to link {platform} and SV accounts!";
        }
    }
}
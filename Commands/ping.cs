﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace CocaBot.Commands
{
    public class ping : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("version")]
        public async Task Version(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("This CocaBot is version 1.3.2").ConfigureAwait(false);
        }
    }
}

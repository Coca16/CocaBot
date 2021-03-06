﻿using ProfanityFilter;
using SpookVooper.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valour.Net.CommandHandling;
using Valour.Net.CommandHandling.Attributes;
using static Shared.Tools;
using static Shared.Commands.Balance;
using static Shared.Commands.Code;

namespace Valour.Commands
{
    class Misc : CommandModuleBase
    {
        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            if (ctx.Member.Nickname == "superjacobl")
            {
                await ctx.ReplyAsync("Jacob Bad!").ConfigureAwait(false);
            }
            else
            {
                await ctx.ReplyAsync("Jacob Good!").ConfigureAwait(false);
            }
        }

        public static string[] AllegateInsults = { "gatey", "german simp", "allegaty", "allegay", "I am free from your will", "Wizard could beat you in any 1v1 Hoi4", "A random fish would be PM before you", "Imagine wanting people to treat you like a dom with a dumb fucking king title and yet being such a sub", "The amount of braincells dedicated just to playing Hoi4 in your brain is 1, or otherwise know as 100%", "> If Germany didn't attack the USSR they would've won WW2", "Allegate when his 1 braincell isn't thinking about Hoi4 (this implies he is looking at Samantha)", "Allegate when he kidnaps a child", "Mfw Allegate made a alternate personality because he was too ugly to be rescued", "Allegate Sus???!!!", "Allegate is going to be ejected for being a sussy imposter!", "After seeing Kaiserreich Allegate has starting heavily sweating and is laughing insanly stating:\n> TRUE GERMANY HAS BEEN ACHIEVED AFJREHSDGJHSDFJHINDFGSJIHNDFG", "people from seattle = crazy gay liberal", "Mfw I compare Allegate's forehead and JacksFils forehead and see that it is bigger", "When Allegate commits sus on his daughter" };

        [Command("say")]
        public async Task SayMultiple(CommandContext ctx, int amount, [Remainder] string Input)
        {
            for (int i = 0; i < amount; i++)
                await SayOnce(ctx, Input).ConfigureAwait(false);
        }

        [Command("say")]
        public async Task SayOnce(CommandContext ctx, [Remainder] string Input)
        {
            Random rnd = new Random();
            int index = rnd.Next(AllegateInsults.Length);
            if (ctx.Member.Nickname == "Allegate")
            {
                await ctx.ReplyAsync(AllegateInsults[index]).ConfigureAwait(false);
                return;
            }
            await ctx.ReplyAsync(Program.Filter.CensorString(Input)).ConfigureAwait(false);
        }

        [Command("code"), Alias("opensource")]
        public async Task Code(CommandContext ctx)
        { await ctx.ReplyAsync(CodeLink).ConfigureAwait(false); }

        [Command("kill")]
        public async Task Kill(CommandContext ctx)
        {
            if (ctx.Member.User_Id == 735182334984219)
            {
                Environment.Exit(666);
            }
        }
    }
}

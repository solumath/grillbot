﻿using Discord.WebSocket;
using GrillBot.Data.Models.API.Guilds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrillBot.Tests.Data.Models.API.Guilds
{
    [TestClass]
    public class GuildTests
    {
        [TestMethod]
        public void EmptyConstructor()
        {
            TestHelpers.CheckDefaultPropertyValues(new Guild(), (defaultValue, value, _) => Assert.AreEqual(defaultValue, value));
        }

        [TestMethod]
        public void SocketGuildConstructor_NullGuild()
        {
            var guild = new Guild(null as SocketGuild);
            TestHelpers.CheckDefaultPropertyValues(guild, (defaultValue, value, _) => Assert.AreEqual(defaultValue, value));
        }

        [TestMethod]
        public void Constructor_FillMemberCount()
        {
            var guild = new Guild() { MemberCount = 50 };
            Assert.AreEqual(50, guild.MemberCount);
        }
    }
}
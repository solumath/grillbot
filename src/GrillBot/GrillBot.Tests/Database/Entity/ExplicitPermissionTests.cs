﻿using GrillBot.Database.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrillBot.Tests.Database.Entity
{
    [TestClass]
    public class ExplicitPermissionTests
    {
        [TestMethod]
        public void Entity_Properties_Default()
        {
            TestHelpers.CheckDefaultPropertyValues(new ExplicitPermission());
        }

        [TestMethod]
        public void Entity_Properties_Filled()
        {
            var permission = new ExplicitPermission()
            {
                Command = "Command",
                IsRole = true,
                TargetId = "Target"
            };

            TestHelpers.CheckNonDefaultPropertyValues(permission);
        }
    }
}
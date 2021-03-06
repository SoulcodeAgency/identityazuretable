﻿// MIT License Copyright 2020 (c) David Melendez. All rights reserved. See License.txt in the project root for license information.

using System;
using ElCamino.AspNetCore.Identity.AzureTable.Helpers;
using ElCamino.AspNetCore.Identity.AzureTable.Model;
using Xunit;

namespace ElCamino.Web.Identity.AzureTable.Tests.ModelTests
{
    public class IdentityUserRoleTests
    {
        [Fact(DisplayName = "IdentityUserRoleGet_UserId")]
        [Trait("IdentityCore.Azure.Model", "")]
        public void IdentityUserRoleGet_UserId()
        {
            var ur = new IdentityUserRole();
            ur.GenerateKeys(new DefaultKeyHelper());
            Assert.Equal(ur.PartitionKey, ur.UserId);
        }
    }
}

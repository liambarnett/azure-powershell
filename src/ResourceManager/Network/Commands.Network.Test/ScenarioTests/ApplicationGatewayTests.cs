﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Commands.Network.Test.ScenarioTests
{
    public class ApplicationGatewayTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public ApplicationGatewayTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestAvailableSslOptions()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-AvailableSslOptions"));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestAvailableWafRuleSets()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-AvailableWafRuleSets"));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestApplicationGatewayCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-ApplicationGatewayCRUD -baseDir '{0}'", AppDomain.CurrentDomain.BaseDirectory));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestApplicationGatewayCRUD2()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-ApplicationGatewayCRUD2 -baseDir '{0}'", AppDomain.CurrentDomain.BaseDirectory));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestApplicationGatewayCRUD3()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-ApplicationGatewayCRUD3 -baseDir '{0}'", AppDomain.CurrentDomain.BaseDirectory));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, Category.nvadev)]
        public void TestApplicationGatewayCRUDRewriteRuleSet()
        {
            NetworkResourcesController.NewInstance.RunPsTest(_logger, string.Format("Test-ApplicationGatewayCRUDRewriteRuleSet -baseDir '{0}'", AppDomain.CurrentDomain.BaseDirectory));
        }
    }
}

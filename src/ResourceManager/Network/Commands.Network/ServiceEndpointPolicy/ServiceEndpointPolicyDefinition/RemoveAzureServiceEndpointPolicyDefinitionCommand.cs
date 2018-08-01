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

using Microsoft.Azure.Commands.Network.Models;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Remove, "AzureRmServiceEndpointPolicyDefinition"), OutputType(typeof(PSServiceEndpointPolicy))]
    public class RemoveAzureServiceEndpointPolicyDefinitionCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = "The name of the service endpoint definition")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
             Mandatory = true,
             ValueFromPipeline = true,
             HelpMessage = "The ServiceEndpointPolicy")]
        public PSServiceEndpointPolicy ServiceEndpointPolicy { get; set; }

        public override void Execute()
        {
            base.Execute();

            // Verify if the rule exists in the NetworkSecurityGroup
            var serviceEndpointPolicyDefinition = this.ServiceEndpointPolicy.ServiceEndpointPolicyDefinition.SingleOrDefault(resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

            if (serviceEndpointPolicyDefinition != null)
            {
                this.ServiceEndpointPolicy.ServiceEndpointPolicyDefinition.Remove(serviceEndpointPolicyDefinition);
            }

            WriteObject(this.ServiceEndpointPolicy);
        }
    }
}

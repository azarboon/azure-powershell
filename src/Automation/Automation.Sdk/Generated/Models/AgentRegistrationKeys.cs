// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the agent registration keys.
    /// </summary>
    public partial class AgentRegistrationKeys
    {
        /// <summary>
        /// Initializes a new instance of the AgentRegistrationKeys class.
        /// </summary>
        public AgentRegistrationKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentRegistrationKeys class.
        /// </summary>

        /// <param name="primary">Gets or sets the primary key.
        /// </param>

        /// <param name="secondary">Gets or sets the secondary key.
        /// </param>
        public AgentRegistrationKeys(string primary = default(string), string secondary = default(string))

        {
            this.Primary = primary;
            this.Secondary = secondary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the primary key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primary")]
        public string Primary {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the secondary key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secondary")]
        public string Secondary {get; set; }
    }
}
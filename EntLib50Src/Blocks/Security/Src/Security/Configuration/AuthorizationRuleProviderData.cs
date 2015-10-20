//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Security Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Security Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Configuration
{
    /// <summary>
    /// Represents the configuration data for an
    /// <see cref="Microsoft.Practices.EnterpriseLibrary.Security.AuthorizationRuleProvider"/>.
    /// </summary>
    [ResourceDescription(typeof(DesignResources), "AuthorizationRuleProviderDataDescription")]
    [ResourceDisplayName(typeof(DesignResources), "AuthorizationRuleProviderDataDisplayName")]
    [ViewModel(SecurityDesignTime.ViewModelTypeNames.AuthorizationRuleProviderDataViewModel)]
	public class AuthorizationRuleProviderData : AuthorizationProviderData
    {
        private const string rulesProperty = "rules";

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="AuthorizationRuleProviderData"/> class.
        /// </summary>
        public AuthorizationRuleProviderData()
        {
            Type = typeof(AuthorizationRuleProvider);
        }

        
		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="AuthorizationRuleProviderData"/> class.
		/// </summary>
		/// <param name="name">The name of the element.</param>
		public AuthorizationRuleProviderData(string name)
			: base(name, typeof(AuthorizationRuleProvider))
		{
		}							

        /// <summary>
        /// Gets or sets the list of rules associated with
        /// the provider.
        /// </summary>
		/// <value>A collection of <see cref="AuthorizationRuleData"/>.</value>
		[ConfigurationProperty(rulesProperty, IsRequired= false)]
        [ConfigurationCollection(typeof(AuthorizationRuleData))]
        [ResourceDescription(typeof(DesignResources), "AuthorizationRuleProviderDataRulesDescription")]
        [ResourceDisplayName(typeof(DesignResources), "AuthorizationRuleProviderDataRulesDisplayName")]
        [PromoteCommands]
		public NamedElementCollection<AuthorizationRuleData> Rules
		{
			get
			{
				return (NamedElementCollection<AuthorizationRuleData>)base[rulesProperty];
			}
		}
    }
}

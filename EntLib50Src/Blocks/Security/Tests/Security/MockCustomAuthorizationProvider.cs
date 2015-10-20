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

using System.Collections.Specialized;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Tests
{
    public class MockCustomAuthorizationProvider
        : IAuthorizationProvider
    {
        private readonly NameValueCollection _attributes;

        public MockCustomAuthorizationProvider(NameValueCollection attributes)
        {
            _attributes = attributes;
        }

        public bool Authorize(System.Security.Principal.IPrincipal principal, string context)
        {
            throw new System.Exception("The method or operation is not implemented.");
        }
    }
}

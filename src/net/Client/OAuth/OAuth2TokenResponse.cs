//-----------------------------------------------------------------------
// <copyright file="OAuth2TokenResponse.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>

using System.Runtime.Serialization;

namespace Microsoft.WindowsAzure.MediaServices.Client.OAuth
{
    /// <summary> 
    /// OAuth2 Token Response class represents wire response when renewing Access Tokens.
    /// </summary> 
    [DataContract]
    public class OAuth2TokenResponse
    {
        /// <summary> 
        /// Gets or sets current access token value.
        /// </summary> 
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        /// <summary> 
        /// Gets or sets current refresh token value. 
        /// </summary> 
        [DataMember(Name = "expires_in")]
        public int ExpirationInSeconds { get; set; }
    }
}

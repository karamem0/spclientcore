//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Microsoft.IdentityModel.JsonWebTokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public class AadOAuthTokenDictionary : Dictionary<string, AadOAuthToken>
    {

        private static readonly JsonSerializer JsonSerializer = new JsonSerializer();

        private static readonly FileInfo FileInfo = new FileInfo(
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".spclientcore",
                "oauthtoken.json"
            ));

        public static AadOAuthTokenDictionary Load()
        {
            if (FileInfo.Exists)
            {
                var json = File.ReadAllText(FileInfo.FullName);
                if (JsonSerializer.TryDeserialize(json, out AadOAuthTokenDictionary oAuthTokens))
                {
                    return oAuthTokens;
                }
                if (JsonSerializer.TryDeserialize(json, out AadOAuthToken oAuthToken))
                {
                    var jwtToken = new JsonWebToken(oAuthToken.AccessToken);
                    var jwtAudience = jwtToken.GetPayloadValue<string>("aud");
                    return new AadOAuthTokenDictionary()
                    {
                        { jwtAudience, oAuthToken }
                    };
                }
            }
            return new AadOAuthTokenDictionary();
        }

        public AadOAuthTokenDictionary()
        {
        }

        public void Save()
        {
            FileInfo.Directory.Create();
            using (var stream = FileInfo.Open(FileMode.Create, FileAccess.Write))
            using (var writer = new JsonTextWriter(new StreamWriter(stream)))
            {
                JsonSerializer.Serialize(writer, this);
            }
        }

    }

}

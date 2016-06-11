using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace MobileStore.Authentication
{
    public class JwtHelper
    {
        private string UserIdentifierKey = "userIdentifier";

        public string CreateToken(string userIdentifier)
        {
            JwtSecurityTokenHandler jwtTokenHandler = new JwtSecurityTokenHandler();
            ////var r = jwtTokenHandler.CreateToken("IamIssuer");
            JwtHeader header = new JwtHeader();
           // //header.Add("user", "pujan");
            JwtPayload payload = new JwtPayload();
           // //payload.Add("urole", "role1,role2");
            payload.Add(UserIdentifierKey, userIdentifier);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(header, payload);

            return jwtTokenHandler.WriteToken(jwtSecurityToken);
            // return r;
        }

        public string GetUserIdentifier(string token)
        {
            var claimsPrincipal = ValidateToken(token);
            var userIdentifier = claimsPrincipal.Claims.Where(x => x.Type == UserIdentifierKey).FirstOrDefault();
            return userIdentifier.Value;

            //return "";
        }

        private ClaimsPrincipal ValidateToken(string token)
        {
            JwtSecurityTokenHandler jwtTokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var validationParameters =
               new TokenValidationParameters
               {
                   IssuerValidator = (s, st, tvp) => { return "IamIssuer"; },
                   RequireSignedTokens = false,
                   ValidateAudience = false,
                   ValidateLifetime = false,
               };
            var claimsPrincipal = jwtTokenHandler.ValidateToken(token, validationParameters, out securityToken);
            return claimsPrincipal;
        }


    }
}
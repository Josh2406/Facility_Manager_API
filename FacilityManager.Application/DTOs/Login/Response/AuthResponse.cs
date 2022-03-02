using System.Collections.Generic;

namespace FacilityManager.Application.DTOs.Login.Response
{
    public class AuthResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string Username { get; set; }
        public AuthResponseData Data { get; set; }
    }

    public class AuthResponseData
    {
        public bool IsStaff { get; set; }
        public List<string> Roles { get; set; }
        public string AuthToken { get; set; }
        public string AuthType { get; set; }
        public int TokenExpiryInMins { get; set; }
    }
}

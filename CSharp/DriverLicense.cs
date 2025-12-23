using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp
{
    public static class DriverLicense
    {
        internal static Dictionary<string, Regex> StateLicenseFormats = new Dictionary<string, Regex>
        {
            {"NE", new Regex(@"^[a-zA-Z]\d{6,8}$")},
            {"MS", new Regex(@"^\d{9}$")}
        };


        /// <summary>
        /// Consider this list of formats: https://ntsi.com/drivers-license-format/
        /// Validate Driver's license number, implement Nebraska and Mississippi in an expandable way to eventually handle all US states.
        /// Fail validation if unexpected data is passed in.
        /// Nebraska: 1Alpha+6-8Numeric
        /// Mississippi: 9Numeric
        /// </summary>
        /// <param name="licenseNumber"></param>
        /// <param name="stateCode"></param>
        /// <returns></returns>
        public static bool Validate(string licenseNumber, string stateCode)
        {
            if (string.IsNullOrEmpty(stateCode) || !StateLicenseFormats.TryGetValue(stateCode, out Regex licenseRules))
                return false;

            var result = licenseRules.Match(licenseNumber).Success;
            
            return result;
        }

    }
}

﻿using System.Collections.Generic;

namespace AspNetCoreRateLimit
{
    public class IpRateLimitOptions : RateLimitOptions
    {
        /// <summary>
        /// Gets or sets the HTTP header of the real ip header injected by reverse proxy, by default is X-Real-IP
        /// </summary>
        public string RealIpHeader { get; set; } = "X-Real-IP";

        /// <summary>
        /// Gets or sets the HTTP header that holds the client identifier, by default is X-ClientId
        /// </summary>
        public string ClientIdHeader { get; set; } = "X-ClientId";

        /// <summary>
        /// Gets or sets the policy prefix, used to compose the client policy cache key
        /// </summary>
        public string IpPolicyPrefix { get; set; } = "ippp";
        public string IpTempBanPeriod { get; set; } = "1h";
        public int IpFloodWarningFactor { get; set; } = 2;
        public int IpFloodBanFactor { get; set; } = 3;

        public List<string> IpWhitelist { get; set; }
    }
}
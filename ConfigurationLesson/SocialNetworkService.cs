using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationLesson
{
    public class SocialNetworkService
    {
        private readonly string googleToken;
        private readonly string twillioToken;

        public SocialNetworkService(IOptions<SocialMediaOption> options)
        {
            googleToken = options.Value.GoogleToken;
            twillioToken = options.Value.TwillioToken;
        }

        public void ToDo()
        {
            // используем токены гугла и твилио
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string to, string subject, string body){
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
        }
        //INSERT BODY
    }

}

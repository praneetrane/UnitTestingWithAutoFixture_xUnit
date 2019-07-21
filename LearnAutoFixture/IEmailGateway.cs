using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
   public  interface IEmailGateway
    {
        void Send(EmailMessage message);
    }
}

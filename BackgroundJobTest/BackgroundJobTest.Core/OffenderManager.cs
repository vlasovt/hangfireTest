using System;
using System.Collections.Generic;
using System.Text;

namespace BackgroundJobTest.Core
{
    public class OffenderManager : IOffenderManager
    {
        public void CreateNewOffender()
        {
            Console.WriteLine("New Offender Is Created");
        }
    }
}

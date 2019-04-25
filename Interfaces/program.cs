using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class program
    {
        static void Main(string[] args)
        {
            Report myReport = new Report();

            myReport.ToString();

            IPrintable myReport2 = new Report();

            myReport2.GetTitle();

        }
    }
}

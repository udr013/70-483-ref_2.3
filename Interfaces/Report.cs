using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Report : IPrintable, IDisplay
    {

        //make interface methods explicit implementations by preceding themethod by the interface name
        string IPrintable.GetPrintableText(int pageWidth, int pageHight)
        {
            return "Report text to be printed";
        }

        string IPrintable.GetTitle()
        {
            return "Report text to be printed";
        }

        string IDisplay.GetTitle()
        {
            throw new NotImplementedException();
        }
    }
}

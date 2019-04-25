namespace Interfaces
{
    internal interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHight);
        string GetTitle();
    }
}
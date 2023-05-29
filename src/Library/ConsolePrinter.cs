using System;
using System.Collections.Generic;
namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        
        
        public void PrintRecipe(IGetTextToPrint getTextToPrint)
        {
            Console.WriteLine(getTextToPrint.GetTextToPrint());
        }
    }
}
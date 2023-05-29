using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        
        public void PrintRecipe(IGetTextToPrint getTextToPrint)
        {
            File.WriteAllText("Recipe.txt", getTextToPrint.GetTextToPrint());
        }
    }
}
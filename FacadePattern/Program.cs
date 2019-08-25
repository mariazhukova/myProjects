using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR cLR = new CLR();
            VisualStudioFacade visualStudio = new VisualStudioFacade(textEditor, compiller, cLR);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(visualStudio);

            Console.ReadKey();
        }
    }
}

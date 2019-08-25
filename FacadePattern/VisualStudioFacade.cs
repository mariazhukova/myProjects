using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class VisualStudioFacade
    {
        TextEditor TextEditor;
        Compiller Compiller;
        CLR CLR;
        public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR clr)
        {
            TextEditor = textEditor;
            Compiller = compiller;
            CLR = clr;
        }

        public void Start()
        {
            TextEditor.CreateCode();
            TextEditor.SaveCode();
            Compiller.Compille();
            CLR.Execute();
        }

        public void Stop()
        {
            CLR.Finish();
        }
    }
}

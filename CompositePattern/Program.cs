using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("file system");
            Component diskC = new Directory("С");
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            fileSystem.Add(diskC);
            fileSystem.Display();
            Console.WriteLine();
            diskC.Remove(pngFile);
            Component docsFolder = new Directory("Мои Документы");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Display();

            Console.Read();
        }
    }
}

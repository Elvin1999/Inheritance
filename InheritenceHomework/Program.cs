using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceHomework
{
    class Document
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    class ProDocument : Document
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("ProDocument Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine(" Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertDocument : ProDocument {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document document;

        }
    }
}

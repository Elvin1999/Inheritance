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
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
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
            string select = Console.ReadLine();
            var nstring=select.Trim();
           var nnstring= nstring.ToLower();
            switch (nnstring)
            {
                case "basic":
                    {
                        document = new Document();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }

                case "pro":
                    {
                        document = new ProDocument();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }
                case "expert":
                    {
                        document = new ExpertDocument();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }
            }
        }
    }
}

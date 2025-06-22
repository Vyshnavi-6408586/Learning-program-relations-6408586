using System;

namespace FactoryMethodPatternExample
{
    public interface IDocument
    {
        void Open();
        void Close();
    }

    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Word document");
        public void Close() => Console.WriteLine("Closing Word document");
    }

    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening PDF document");
        public void Close() => Console.WriteLine("Closing PDF document");
    }

    public class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Excel document");
        public void Close() => Console.WriteLine("Closing Excel document");
    }
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();

        public void OpenDocument()
        {
            var doc = CreateDocument();
            doc.Open();
        }

        public void CloseDocument()
        {
            var doc = CreateDocument();
            doc.Close();
        }
    }

    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new WordDocument();
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new ExcelDocument();
    }
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory;

            string[] types = { "Word", "PDF", "Excel", "TXT" };
            foreach (var type in types)
            {
                try
                {
                    factory = type switch
                    {
                        "Word" => new WordDocumentFactory(),
                        "PDF" => new PdfDocumentFactory(),
                        "Excel" => new ExcelDocumentFactory(),
                        _ => throw new ArgumentException($"Unknown document type: {type}")
                    };

                    Console.WriteLine($"\n-- Handling {type} document --");
                    factory.OpenDocument();
                    factory.CloseDocument();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

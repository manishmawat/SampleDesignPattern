using System;
using System.Text;

namespace StartegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dynamic strategy pattern.
            //There is one static strategy pattern also where we intantiate specific type of object at compile time and at runtime.
            IStrategy type = new HtmlListElement("ul", "li");
            type.start();
            type.AddItem("Ad");
            type.AddItem("Bin");
            type.AddItem("Man");
            type.end();
            Console.WriteLine(type);

            type = new MarkUpElement();
            type.AddItem("Ad");
            type.AddItem("Bin");
            type.AddItem("Man");
            Console.WriteLine(type);
        }
    }

    interface IStrategy
    {
        void start();
        void AddItem(string item);
        void end();
    }

    public class HtmlListElement:IStrategy,ISmallStrategy
    {
        public HtmlListElement(string element,string childElement)
        {
            ElementName = element;
            ChildElement = childElement;
        }
        public string ElementName { get; set; }
        public string ChildElement { get; set; }
        StringBuilder sb = new StringBuilder();
        public void start()
        {
            sb.AppendLine($"<{ElementName}>");
        }

        public void AddItem(string item)
        {
            sb.AppendLine($"<{ChildElement}> {item} </{ChildElement}>");

        }

        public void end()
        {
            sb.AppendLine($"</{ElementName}>");
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }

    interface ISmallStrategy
    {
        void AddItem(string item);
    }

    public class MarkUpElement : IStrategy
    {
        StringBuilder sb = new StringBuilder();
        public void AddItem(string item)
        {
            sb.AppendLine(" * " + item);
        }

        public void end()
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}

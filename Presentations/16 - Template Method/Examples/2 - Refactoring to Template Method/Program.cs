﻿using System.Dynamic;

namespace Wincubate.TemplateMethodExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic person = new ExpandoObject();
            person.FirstName = "Terry";
            person.LastName = "Tate";
            person.Occupation = "Office Linebacker";

            PrettyPrinterBase pp = new XmlPrettyPrinter();
            pp.Print(person, "Person");
        }
    }
}

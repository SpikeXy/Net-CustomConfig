using AppConfigConfigSectionSampleProject.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigConfigSectionSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ((SampleConfiguration)ConfigurationManager.GetSection("Sample"));

            if (config == null)
                throw new Exception("The Sample section is missing from the App.Config");

            Console.WriteLine("config.Group[\"G1\"].Value == {0}",config.Group["G1"].Value);
            Console.WriteLine("config.Group[1].Value == {0}", config.Group[1].Value);
            Console.WriteLine("config.Group[\"G1\"].InnerAnotherBlock.SomeValue == {0}", config.Group["G1"].InnerAnotherBlock.SomeValue);
            Console.WriteLine("config.Group[\"G1\"].AnotherGroup[\"G1AG2\"].Value == {0}", config.Group["G1"].AnotherGroup["G1AG2"].Value);
            Console.WriteLine("config.SingleBlock.Datafield == {0}", config.SingleBlock.Datafield);

            Console.ReadLine();
        }
    }
}

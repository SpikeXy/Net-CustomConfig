using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class InnerAnotherBlockElement : ConfigurationElement
    {
        [ConfigurationProperty("SomeValue")]
        public string SomeValue
        {
            get
            {
                return this["SomeValue"] as string;
            }
            set
            {
                this["SomeValue"] = value;
            }
        }
    }
}

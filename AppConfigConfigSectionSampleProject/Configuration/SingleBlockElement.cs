using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class SingleBlockElement : ConfigurationElement
    {
        [ConfigurationProperty("Datafield")]
        public string Datafield
        {
            get
            {
                return this["Datafield"] as string;
            }
            set
            {
                this["Datafield"] = value;
            }
        }
    }
}

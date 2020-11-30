using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class InnerSingleBlockElement : ConfigurationElement
    {
        [ConfigurationProperty("Value")]
        public string Value
        {
            get
            {
                return this["Value"] as string;
            }
            set
            {
                this["Value"] = value;
            }
        }
    }
}

using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class AnotherGroupElement : ConfigurationElement
    {
        [ConfigurationProperty("Name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return this["Name"] as string;
            }
            set
            {
                this["Name"] = value;
            }
        }

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

using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class GroupElement : ConfigurationElement
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

        [ConfigurationProperty("InnerSingleBlock")]
        public InnerSingleBlockElement InnerSingleBlock
        {
            get
            {
                return this["InnerSingleBlock"] as InnerSingleBlockElement;
            }
            set
            {
                this["InnerSingleBlock"] = value;
            }
        }

        [ConfigurationProperty("InnerAnotherBlock")]
        public InnerAnotherBlockElement InnerAnotherBlock
        {
            get
            {
                return this["InnerAnotherBlock"] as InnerAnotherBlockElement;
            }
            set
            {
                this["InnerAnotherBlock"] = value;
            }
        }

        [ConfigurationProperty("AnotherGroup")]
        public AnotherGroupElementCollection AnotherGroup
        {
            get { return this["AnotherGroup"] as AnotherGroupElementCollection; }
        }

    }
}

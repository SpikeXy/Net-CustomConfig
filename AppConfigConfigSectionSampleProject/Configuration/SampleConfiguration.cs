using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class SampleConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("Group")]
        public GroupElementCollection Group
        {
            get { return this["Group"] as GroupElementCollection; }
        }

        [ConfigurationProperty("SingleBlock")]
        public SingleBlockElement SingleBlock
        {
            get
            {
                return this["SingleBlock"] as SingleBlockElement;
            }
            set
            {
                this["SingleBlock"] = value;
            }
        }

    }
}

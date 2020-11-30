using System;
using System.Configuration;

namespace AppConfigConfigSectionSampleProject.Configuration
{
    public class AnotherGroupElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new AnotherGroupElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((AnotherGroupElement)element).Name;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override string ElementName
        {
            get { return "add"; }
        }

        public AnotherGroupElement this[int index]
        {
            get { return (AnotherGroupElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public AnotherGroupElement this[string name]
        {
            get { return (AnotherGroupElement)BaseGet(name); }
        }
    }
}

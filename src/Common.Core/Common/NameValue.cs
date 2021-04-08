using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    public class NameValue : NameValue<string>
    {
        public NameValue()
        {

        }

        public NameValue(string name, string value)
            : base(name, value)
        {

        }
    }


    [Serializable]
    public class NameValue<TValue>
    {
        public string Name { get; set; }

        public TValue Value { get; set; }

        public NameValue()
        {

        }

        public NameValue(string name, TValue value)
        {
            Name = name;
            Value = value;
        }
    }
}

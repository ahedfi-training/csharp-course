using System;

namespace AttributeLabs
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method , AllowMultiple = true, Inherited = false)]
    internal class CustomAttribute : Attribute
    {
        public CustomAttribute(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}

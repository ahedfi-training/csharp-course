﻿namespace ReflectionLabs
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        void Do();
    }
}
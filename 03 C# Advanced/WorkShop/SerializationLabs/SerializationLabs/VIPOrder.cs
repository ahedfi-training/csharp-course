﻿using System;

namespace SerializationLabs
{
    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Client
{
    internal class Echo_Client
    {
        static void Main(string[] args)
        {
            var clientBuilder = new ClientBuilder();
            clientBuilder.Start();
        }
    }
}

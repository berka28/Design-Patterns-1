﻿using Autofac;
using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }
}

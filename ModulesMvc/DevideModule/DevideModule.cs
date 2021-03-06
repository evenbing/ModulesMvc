﻿using Autofac;
using ModulesContracts;

namespace DevideModule
{
    public class DevideModule: ModuleBase
    {
        public override string ToString()
        {
            return "This module multiply two numbers";
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CalculatorOperation>().As<ICalculatorOperation>();
        }
    }

    public class CalculatorOperation : ICalculatorOperation
    {
        public int Calculate(int x, int y)
        {
            if (x == 0) return 0;
            if (y == 0) return 0;
            return x / y;
        }

        public string Name
        {
            get { return "Devide"; }
        }
    }
}

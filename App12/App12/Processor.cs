﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class Processor<T> : IProcessor<T>
    {
        public void Process(T input)
        {
            Console.WriteLine($"Generic class processor {input}");
        }
    }
    
    public record Cliente(string? nombre, string? apellido);
}

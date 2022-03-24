using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacaoMetodosAbstract.Entities.Enums;

namespace ExercicioFixacaoMetodosAbstract
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}

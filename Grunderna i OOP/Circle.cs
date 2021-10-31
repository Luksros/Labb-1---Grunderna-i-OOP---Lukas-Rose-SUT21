using System;
using System.Collections.Generic;
using System.Text;

namespace Grunderna_i_OOP
{
    class Circle
    {
        float pi = 3.141f;
        int radius;

        public Circle(int inputRadius)
        {
            radius = inputRadius;
        }

        public float GetArea()
        {
            return (radius * radius * pi);
        }
        public float GetCircumference()
        {
            return ((radius * 2) * pi);
        }
        public float GetVolume()
        {
            return ((4 * pi * (radius * radius * radius)) / 3);
        }
        public void CalculateAll()
        {
            Console.WriteLine("Arean på en cirkel med radien " + radius + " är " + GetArea());
            Console.WriteLine("Omkretsen på en cirkel med radien " + radius + " är " + GetCircumference());
            Console.WriteLine("Volymen på ett klot med radien " + radius + " är " + GetVolume());
            Console.WriteLine();
        }
    }
}

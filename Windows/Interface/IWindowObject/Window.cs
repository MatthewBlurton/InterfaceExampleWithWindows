using System;
using System.Collections.Generic;
using System.Text;

namespace Windows.Interface.IWindowObject
{
    class Window : IWindow
    {
        private double _x;
        private double _y;
        private double _width;
        private double _height;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }

        public void Close()
        {
            X = 0.0;
            Y = 0.0;
            Width = 0.0;
            Height = 0.0;
        }

        public void SetMaximum(bool max)
        {
            if (max)
            {
                X = 0.0;
                Y = 0.0;
                Width = 100.0;
                Height = 100.0;
                return;
            }

            X = 25.0;
            Y = 25.0;
            Width = 50.0;
            Height = 50.0;
        }

        public void Show()
        {
            Console.WriteLine("Window: x => {0}, y => {1}, width = {2}, height = {3}", X, Y, Width, Height);
        }
    }
}

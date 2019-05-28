using System;
using System.Collections.Generic;

// Get the interface and it's objects
using Windows.Interface;
using Windows.Interface.IWindowObject;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manage multiple types of windows
            List<IWindow> windowManager = new List<IWindow>();

            // Create two different types of windows with same methods
            Window standard = new Window();
            PopupWindow pop = new PopupWindow();

            // Add both unique types of windows to WindowManager which uses the interface
            windowManager.Add(standard);
            windowManager.Add(pop);

            // Use a loop to set and print the settings of each window in the window manager
            foreach (IWindow window in windowManager)
            {
                window.SetMaximum(false);
                window.Show();
            }

            // Call the unique method from pop
            pop.CustomMethod();
        }
    }
}

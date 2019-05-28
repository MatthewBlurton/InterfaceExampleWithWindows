using System;
using System.Collections.Generic;
using System.Text;

namespace Windows.Interface
{
    interface IWindow
    {
        double X
        {
            get;
            set;
        }

        double Y
        {
            get;
            set;
        }

        double Width
        {
            get;
            set;
        }
        double Height
        {
            get;
            set;
        }

        void Show();
        void Close();
        void SetMaximum(bool max);
    }
}

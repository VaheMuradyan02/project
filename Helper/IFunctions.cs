using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public interface IFunctions<T>
    {
        void Resize(int width, int height, T name);
        void Move(int right, int left, int top, int dow, T name);
        void ZoomIn(int scale, T name);
        void ZoomOut(int scale, T name);
        void Rotate(int degree, T name);
    }
}

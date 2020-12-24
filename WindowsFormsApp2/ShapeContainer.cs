using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ShapeContainer
    {
        public static ArrayList arrayList;
        
        public ShapeContainer()
        {
            arrayList = new ArrayList();
        }

        public static void AddFigure(Figure figure)
        {
            arrayList.Add(figure);
        }
    }
}

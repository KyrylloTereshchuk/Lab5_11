using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IEditor
    {
        public void AddFigure(IFigure figure);
        public string GetState();
        public void SetState(string state);
        public void PrintFigures();
       
    }
}

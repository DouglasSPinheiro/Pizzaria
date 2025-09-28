using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public interface IBuilder
    {
        void Reset();
        //substitua metodo setTaste pelo addTaste e crie uma lista de sabores dentro de pizza
        //void SetTaste(string taste, string tast2, string tast3); 
        void addTaste(string newtaste); 
        void SetEdge(string edge);
        void SetSize(string size);
    }
}

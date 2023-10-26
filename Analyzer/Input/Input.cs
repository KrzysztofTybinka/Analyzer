using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Analyzer.Input
{

    /*1.Najpierw po Path otrzymuje file
      2. potem po Node otrzymuje liste
      3. Musze utworzyć function której chce użyć
      4. Otrzymuje function, przekazuje tam value, używam jej 
      5. zwracam użytkownikowi output*/
    public class Input //node -fc val source        gowno -gt 4 C//..........   builder tu użyć chyba 
    {
        public string Node { get; set; }
        public string Function { get; set; }
        public string Value { get; set; }
        public string Path { get; set; }

        public Input(string command)
        {
            string[] elements = command.Split(" ");  
            

        }
    }
}

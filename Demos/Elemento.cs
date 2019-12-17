using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public class Elemento<T> {
        public T Key { get; set; }
        public string Label { get; set; }

        public Elemento(T key, string label) {
            Key = key;
            Label = label;
        }
    }
}

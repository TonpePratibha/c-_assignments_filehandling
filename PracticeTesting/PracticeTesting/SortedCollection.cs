using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTesting
{
  public class SortedCollection
    {
        public List<int> items { get; set; }
        public SortedCollection() { }   
        public SortedCollection(List<int> items)
        { this.items = items;
       
        }

        public SortedCollection(int[] items) { 
        this.items=new List<int>(items);
        }

        public void BubbleSort(List<int>items) {
            for (var i = 0; i < items.Count; i++) {
                for (var j = 0; j < items.Count - 1; j++) {
                    if (items[j] > items[j + 1]) {
                        var temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }
    }
}

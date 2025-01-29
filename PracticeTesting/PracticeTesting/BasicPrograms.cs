using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTesting
{
    public class BasicPrograms
    {
        public int add(int a, int b) {
            int sum = a + b;
            return sum;
        }
        public bool isEven(int num) {
            var result = num % 2 == 0
                    ;
            if (result) {
                Console.WriteLine("even num");
                return true;

            }
            return false;
        }


        public void BubbleSort(List<int> items) {
            for (var i = 0; i < items.Count; i++) {
                for (var j = 0; j < items.Count - 1; j++) {
                    if (items[j] > items[j + 1]) {
                        var temp = items[j + 1];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }
    }
}

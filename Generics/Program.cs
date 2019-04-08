using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics нужен для того чтобы сократить код и обращаться к любому значению 
            //С помощью generics можно менять тип на момент его создания

            int[] numbersAsArray = { 1, 2, 3, 4, 5 }; //строгая типизация

            ArrayList arrayList = new ArrayList 
            //->Проблема в том что тут может быть любой тип(object)
            {
                1,2,3,4,5,"",new object(), new File()
            };


            //Строгая типизация Т
            List<int> numbersAsList = new List<int>
            {
                1,2,3,4,5
            };
        }
    }
}

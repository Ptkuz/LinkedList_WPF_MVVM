using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class Node<T>
    {
        public T? Data { get; set; } // Текущий элемент
        public Node<T>? Next { get; set; } // Следующий связанный элемент

        public Node(T data) =>
            Data = data;

      

    }
}

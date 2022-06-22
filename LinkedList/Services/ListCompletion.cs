using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Services.Interfaces;
using LinkedListLibrary;

namespace LinkedList.Services
{
    internal class ListCompletion<T> : IListCompletion<string>
    {
        
       public LinkedListLibrary.LinkedList<string> Completion()
        {
            LinkedListLibrary.LinkedList<string> list = new LinkedListLibrary.LinkedList<string>();
            list.Add("Шепард");
            list.Add("Миранда");
            list.Add("Гаррус");
            list.Add("Рекс");
            return list;
        }

       
    }
}

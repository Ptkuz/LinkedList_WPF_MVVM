using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public interface IMethods<T>
    {
        void Add(T data);
        void AppendFirst(T data);
        bool Remove(T data);
        bool Contains(T data);
        void Clear();
    }
}

using System.Collections.Generic;
using System.Collections;


namespace LinkedListLibrary
{
    public class LinkedList<T> : IEnumerable<T>, IMethods<T>
    {
        Node<T>? head; // Головной элемент
        Node<T>? tail; // Хвостовой элемент
        int count;

        public int Count { get => count; }
        public bool IsEmpty { get => count == 0; }


        // Добавление нового элемента
        public void Add(T data)
        {
          Node<T> node = new Node<T>(data); // Создаем новый объем списка

            if(head == null) // Если голова пуста, то это будет первым элементом
                head = node;
            else
                tail.Next = node; // Или же свойсто tail будет хранить последний элемент node
            tail = node; // Свойства хранит последний элемент в хвосте
            count++; // Увеличиваем количество элементов
        }

        // Добавить элемент в начало списка
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            head.Next = node;
            head = node;
            if(count == 0)
                tail = head;
            count++;
        }

        // Удалить элемент из списка
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T>? previous = null;

            while (current != null) 
            {
                if (current.Data.Equals(data)) 
                {
                    if (previous.Next == current.Next)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else 
                    {
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }


        // Отчистить список
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }


        // Содержит ли список заданный элемент
        public bool Contains(T data)
        {
            Node<T>? current = head;
            while (current != null) 
            { 
                if(current.Data.Equals(data))
                   return true;
                current = current.Next;
            }
            return false;
        }
      

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null) 
            { 
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

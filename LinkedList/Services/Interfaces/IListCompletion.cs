using LinkedListLibrary;

namespace LinkedList.Services.Interfaces
{
    internal interface IListCompletion<T>
    {
        LinkedList<T> Completion();
    }
}

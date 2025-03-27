using src.LinearLists.Interfaces;

namespace src.LinearLists
{
    public class LinearList<T> : ILinearList<T>
    {
        private T[] _items;
        private int _size;

        public LinearList():this(4){}

        public LinearList(int capacity)
        {
            if (capacity <1)
                throw new ArgumentException("Capacidade precisa pelo menos 1.", nameof(capacity));
            
            _items = new T[capacity];
            _size = 0;
        }

        public LinearList(T[] items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
            _size = items.Length;
        }
         public int Count => _size;

        public bool Search(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_items[i].Equals(item)) 
                    return true;
            }
            return false;
        }
    
        // public bool SearchWithSentinel(T item)
        // {
        //     if (_size == _items.Length) EnsureCapacity(_items.Length + 1);
        //     _items[_size] = item;

        //     int i = 0;
        //     while(!_items[i].Equals(item)) i++;
        //     return (i < _size) ? true : false;
        // }
        //void Add(T item){}
        //bool Remove(T item){return true;}

        public override string ToString()
        {
            // Converte o array em uma string legível
            return string.Join(", ", _items.Take(_size));  // Utiliza LINQ para pegar os itens no array até _size
        }
    }
}
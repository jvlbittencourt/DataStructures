using System;
using System.Collections;
using System.Collections.Generic;

namespace src.LinearLists.Interfaces
{
    public interface ILinearList<T> 
    {
        //void Add(T item);
        //bool Remove(T item);
        bool Search(T item);
        //int Count { get; }
    }
}
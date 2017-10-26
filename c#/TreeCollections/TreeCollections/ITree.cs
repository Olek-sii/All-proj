using System;

namespace TreeCollections
{
    public interface ITree : IEquatable<ITree>
    {
        void Init(int[] ini);
        void Add(int val);
        void Del(int val);
        int[] ToArray();
        int Size();
        int Height();
        int Width();
        int Nodes();
        int Leafs();
        void Reverse();
    }
}

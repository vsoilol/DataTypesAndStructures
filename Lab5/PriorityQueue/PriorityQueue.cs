using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.PriorityQueue
{
    public class PriorityQueue<TPriority, TValue> : IEnumerable<KeyValuePair<TPriority, TValue>>
        where TPriority : IComparable
    {
        private readonly List<Element> _elements;

        public PriorityQueue()
        {
            _elements = new List<Element>();
        }
        
        public int Count => _elements.Count;
        
        public void Enqueue(TPriority priority, TValue value)
        {
            var newElement = new Element(priority, value);

            _elements.Add(newElement);
            _elements.Sort(new PriorityQueueComparer());
        }
        
        public TValue Dequeue()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessage.EmptyPriorityQueue);
            }

            var value = _elements[0].Value;
            _elements.RemoveAt(0);

            return value;
        }

        public IEnumerator<KeyValuePair<TPriority, TValue>> GetEnumerator()
        {
            foreach (var item in _elements)
            {
                yield return new KeyValuePair<TPriority, TValue>(item.Priority, item.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private readonly struct Element
        {
            public Element(TPriority priority, TValue value)
            {
                Priority = priority;
                Value = value;
            }

            public TPriority Priority { get; }
            public TValue Value { get; }
        }

        private class PriorityQueueComparer : IComparer<Element>
        {
            public int Compare(Element x, Element y)
            {
                return x.Priority.CompareTo(y.Priority);
            }
        }
    }
}
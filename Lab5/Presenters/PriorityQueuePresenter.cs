using System;
using Lab5.PriorityQueue;
using Lab5.Providers;
using Lab5.Resources;

namespace Lab5.Presenters
{
    internal class PriorityQueuePresenter
    {
        private readonly PriorityQueue<int, int> _priorityQueue = new();
        private readonly IUIProvider _provider;

        public PriorityQueuePresenter(IUIProvider provider)
        {
            _provider = provider;
        }

        public void Enqueue()
        {
            var value = _provider.GetIntData(UIResources.EnterValueToAdd);
            var priority = _provider.GetIntData(UIResources.EnterPriorityToAdd);
            
            _priorityQueue.Enqueue(priority, value);
        }
        
        public void Dequeue()
        {
            try
            {
                var value = _priorityQueue.Dequeue();
                _provider.ShowMessage(string.Format(UIResources.ElementFromPriorityQueue, value));
            }
            catch (InvalidOperationException ex)
            {
                _provider.ShowMessage(ex.Message);
            }
        }
        
        public void DisplayQueue()
        {
            if (_priorityQueue.Count == 0)
            {
                _provider.ShowMessage(ExceptionMessage.EmptyPriorityQueue);
                return;
            }
            
            foreach (var (key, value) in _priorityQueue)
            {
                _provider.ShowMessage(string.Format(UIResources.KeyValue, key, value));
            }
        }
        
        public void DisplayQueueCount()
        {
            _provider.ShowMessage(string.Format(UIResources.AmountElementsInQueue, _priorityQueue.Count));
        }
    }
}
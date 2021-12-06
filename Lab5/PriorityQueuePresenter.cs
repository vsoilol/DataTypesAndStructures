using System;
using Lab5.PriorityQueue;

namespace Lab5
{
    public class PriorityQueuePresenter
    {
        private readonly PriorityQueue<int, int> _priorityQueue = new();

        public void Enqueue()
        {
            Console.Write($"Введите число которое хотите добавить: ");
            var value = int.Parse(Console.ReadLine());
            
            Console.Write($"Введите приоритет этого числа: ");
            var priority = int.Parse(Console.ReadLine());
            
            _priorityQueue.Enqueue(priority, value);
        }
        
        public void Dequeue()
        {
            try
            {
                var value = _priorityQueue.Dequeue();
                Console.WriteLine($"Первое значение в приоритетной очереди: {value}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void DisplayQueue()
        {
            foreach (var (key, value) in _priorityQueue)
            {
                Console.WriteLine($"Приоритет: {key}, Значение: {value}");
            }
        }
        
        public void DisplayQueueCount()
        {
            Console.WriteLine($"Количество элементов в приоритетной очереди: {_priorityQueue.Count}");
        }
    }
}
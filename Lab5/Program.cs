using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ConsoleTools;
using Lab5.PriorityQueue;

namespace Lab5
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var priorityQueuePresenter = new PriorityQueuePresenter();
            
            Console.ForegroundColor = ConsoleColor.Gray;
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Отобразить приоритетную очередь", priorityQueuePresenter.DisplayQueue)
                .Add("Добавить в приоритетную очередь", priorityQueuePresenter.Enqueue)
                .Add("Достать из приоритетной очереди", priorityQueuePresenter.Dequeue)
                .Add("Количество элементо в приоритетной очереди", priorityQueuePresenter.DisplayQueueCount)
                .Add("Выход", ConsoleMenu.Close)
                .Configure(config =>
                {
                    config.Selector = "--> ";
                    config.EnableFilter = false;
                    config.Title = "Приоритетная очередь";
                    config.EnableWriteTitle = true;
                });

            menu.Show();

        }
    }
}
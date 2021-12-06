using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ConsoleTools;
using Lab5.Presenters;
using Lab5.PriorityQueue;
using Lab5.Providers;

namespace Lab5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var provider = new ConsoleProvider();
            
            var priorityQueuePresenter = new PriorityQueuePresenter(provider);
            
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
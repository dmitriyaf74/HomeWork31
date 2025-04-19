using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Classes
{

    internal class MyCD : ConcurrentDictionary<string, int>;

    internal class Library
    {
        private MyCD _data = new MyCD();
        private BlockingCollection<KeyValuePair<string, int>> _queue = new BlockingCollection<KeyValuePair<string, int>>();
        private Task _workerTask;
        private CancellationTokenSource _cts = new CancellationTokenSource();


        public Library()
        {
            // Запускаем задачу-обработчик, которая будет брать элементы из очереди.
            _workerTask = Task.Run(() => ProcessQueue(_cts.Token));
            _workerTask.ConfigureAwait(false);
        }

        public MyCD Data {  get { return _data; } }


        public void AddBook(string BookName) 
        {
            _data.TryAdd(BookName, 0);
            _queue.Add(new KeyValuePair<string, int>(BookName, 0));
        }

        private void ProcessQueue(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                    break;
                if (_data.Count == 0) 
                    break;

                Random random = new Random();
                int randomNumber = random.Next(0, _data.Count);
                var key = _data.ElementAt(randomNumber).Key;
                _data[key]++;
                if (_data[key] == 100)
                {
                    int value;
                    _data.Remove(key, out value);
                }
                Thread.Sleep(100);

                //for (int i = 0; i < _data.Count; i++)
                //    _data[_data.ElementAt(i).Key]++;
            }
        }

        public void Stop()
        {
            // Сигнализируем об отмене задачи-обработчика.
            _cts.Cancel();
            // Завершаем добавление новых элементов в очередь.
            _queue.CompleteAdding();
            // Ожидаем завершения задачи-обработчика (с таймаутом).
            _workerTask.Wait(5000);
            _cts.Dispose();
            _queue.Dispose();
        }

    }
}

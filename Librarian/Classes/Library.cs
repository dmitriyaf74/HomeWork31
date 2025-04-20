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
        private Task _workerTask;
        private CancellationTokenSource _cts = new CancellationTokenSource();


        public Library()
        {
            _workerTask = Task.Run(() => ProcessQueue(_cts.Token));
            _workerTask.ConfigureAwait(false);
        }

        public MyCD Data {  get { return _data; } }


        public void AddBook(string BookName) 
        {
            _data.TryAdd(BookName, 0);
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
                int randomNumber = random.Next(0, 999);
                var key = _data.ElementAt(randomNumber % _data.Count).Key;
                _data[key]++;
                if (_data[key] == 100)
                {
                    int value;
                    _data.Remove(key, out value);
                }
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            _cts.Cancel();
            _workerTask.Wait(5000);
            _cts.Dispose();
        }

    }
}

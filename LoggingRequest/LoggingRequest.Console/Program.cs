using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoggingRequest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int instances = 5;
            var tasks = new Task[instances];
            for (int i = 0; i < instances; i++)
            {
                tasks[i] = Test();
            }

            Task.WaitAll(tasks);
        }

        static Task Test()
        {
            var webClient = new WebClient();

            return webClient.DownloadStringTaskAsync("http://localhost:55405/");
        }
    }
}

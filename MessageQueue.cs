using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectData
{
    public class MessageQueue : IDisposable
    {
        private Queue<ICommand> CommandList = new Queue<ICommand>();
        private ManualResetEvent Controller = new ManualResetEvent(false);
        private Thread QueueThread = null;
        private Object QueueLockObj = new object();

        public bool IsAlive { get; private set; }

        public MessageQueue()
        {
            this.QueueThread = new Thread(this.ExecuteMessage)
            {
                IsBackground = true,
                Name = "MessageQueue"
            };
            this.IsAlive = true;
            this.QueueThread.Start();
        }

        public void Enqueue(ICommand command)
        {
            this.CommandList.Enqueue(command);
            this.Controller.Set();
        }

        private void ExecuteMessage()
        {
            try
            {
                while (IsAlive)
                {
                    while (this.CommandList.Count > 0)
                    {
                        ICommand command = this.CommandList.Dequeue();
                        command.Execute(null);
                    }
                    this.Controller.Reset();
                    this.Controller.WaitOne(Timeout.Infinite);
                }
            }
            catch (ThreadAbortException e) { }
        }
        public void Dispose()
        {
            this.IsAlive = false;
            this.Controller.Set();
            this.QueueThread.Abort();
        }
    }
}

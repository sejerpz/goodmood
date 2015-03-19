using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood.UI
{
    class Dispatcher
    {
        private List<Action> actions = new List<Action>();
        private SynchronizationContext context;

        public Dispatcher()
        {
            this.context = SynchronizationContext.Current;
        }

        public void Invoke(Action action)
        {
            this.context.Send(new SendOrPostCallback((state) =>
            {
                var callback = (Action)state;

                callback.Invoke();
            }), action);
        }

    }
}

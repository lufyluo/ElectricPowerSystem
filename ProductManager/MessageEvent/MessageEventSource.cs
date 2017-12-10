using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.MessageEvent
{
    public class MessageEventSource
    {
        public delegate void MessageEventHandler(object sender, MessageEventArgs e);
        public event MessageEventHandler MessageEvent;
        //事件触发方法

        protected virtual void OnTestEvent(MessageEventArgs e)
        {

            if (MessageEvent != null)

                MessageEvent(this, e);

        }

        //引发事件

        public void RaiseEvent(string msg)
        {

            MessageEventArgs e = new MessageEventArgs(msg);

            OnTestEvent(e);

        }

    }

}

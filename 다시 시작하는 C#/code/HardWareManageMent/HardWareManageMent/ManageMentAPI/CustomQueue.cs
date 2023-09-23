using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWareManageMent.ManageMentAPI
{
    //명시형 delegate 생성 
    public delegate void QueueEventHandler<T, U>(T sender, U eventArgs);
    public class CustomQueue<T> where T : IEntitiyPrimaryProperties, IEntityAdditionalProperties
    {
        Queue<T> _queue = null;

        public event QueueEventHandler<CustomQueue<T>, QueueEventArgs> CustomQueueEvent;
        public CustomQueue()
        {
            _queue = new Queue<T>();
        }
        public int QueueLength
        {
            get { return _queue.Count; }
        }
        public void AddItem(T item)
        {
            _queue.Enqueue(item);

            QueueEventArgs queueEventArgs = new QueueEventArgs { Message = $"DateTime : {DateTime.Now.ToString(Content.DateFormat)}," +
                                                             $" id : {item.id}, Name {item.name}, Type : {item.Type}, Quantity {item.Quantity}, 큐가 추가 되었습니다."};
            OnQueueChanged(queueEventArgs);

            
        }
        public T GetItem()
        {
            
            return _queue.Dequeue();
        }
        protected virtual void OnQueueChanged(QueueEventArgs e) 
        {
            CustomQueueEvent(this, e);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
        
    }
    public class QueueEventArgs:System.EventArgs
        {
            public string Message { get; set; }
    }
}

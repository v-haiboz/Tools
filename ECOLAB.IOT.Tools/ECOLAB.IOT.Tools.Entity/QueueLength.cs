namespace ECOLAB.IOT.Tools.Entity
{
    using System.Collections.Generic;

    public class QueueLength<T>: Queue<T>
    {
        int length = 1;
        public QueueLength(int length) : base(length)
        {
            this.length = length;
        }

        public new void Enqueue(T item)
        {

            if (base.Count == length)
                base.Dequeue();

            base.Enqueue(item);
        }
    }
}

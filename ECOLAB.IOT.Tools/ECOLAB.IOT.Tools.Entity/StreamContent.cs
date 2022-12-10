namespace ECOLAB.IOT.Tools.Entity
{
    public class ECOLABStreamContent
    {
        private readonly string _Content;
        private readonly StreamType _StreamType;
        private readonly int _DataLen;

        public ECOLABStreamContent(StreamType type, string content, int dataLen)
        {
            _Content = content;
            _DataLen = dataLen;
            _StreamType = type;
        }

        public StreamType Type
        {
            get { return _StreamType; }
        }

        public string Content
        {
            get { return _Content; }
        }

        public int DataLen
        {
            get { return _DataLen; }
        }
    }

    public enum StreamType : int
    {
        Receive,
        Send,
    }
}

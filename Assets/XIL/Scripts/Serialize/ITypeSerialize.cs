namespace wxb
{
    public interface ITypeSerialize
    {
        byte typeFlag { get; } // ���ͱ�ʶ
        void WriteTo(object value, IStream ms);
        void MergeFrom(ref object value, IStream ms);
        int CalculateSize(object value);
    }

    public class NullTypeSerialize : ITypeSerialize
    {
        static NullTypeSerialize nullTypeSerialize = new NullTypeSerialize();
        public static ITypeSerialize instance { get { return nullTypeSerialize; } }

        // ���ͱ�ʶ
        byte ITypeSerialize.typeFlag { get { return 250; } }

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {

        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            value = null;
        }

        int ITypeSerialize.CalculateSize(object value)
        {
            return 0;
        }
    }
}
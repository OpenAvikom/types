
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Vision
{

    /** This message represents a (chunk of an) image. It may contain an `ImageInfo` header or a chunk of data of an image. */
    [CreateAssetMenu(menuName = "Avikom/Vision/Image")]
    public class Image : GameEvent<Image>, IGameEvent
    {
        public static Avikom.Types.Vision.Image TypeDefault = null;
        // an information header defining size, dimensions and transfer parameters
        public Avikom.UnityTypes.Vision.ImageInfo Info;

        // a series of bytes (size defined by `chunk_size` in `info`) representing a chunk of an image
        public ByteArrayVariable Data;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Vision.Image proto)
        {

            if (Info == null) { Info = ScriptableObject.CreateInstance<Avikom.UnityTypes.Vision.ImageInfo>(); }
            if (proto.Info != Avikom.UnityTypes.Vision.ImageInfo.TypeDefault)
            {
                Info.SetValue(proto.Info);
            }

            if (Data == null) { Data = ScriptableObject.CreateInstance<ByteArrayVariable>(); }
            if (!proto.Data.IsEmpty)
            {
                Data.SetValue(proto.Data.ToByteArray());
            }
            Raise();
        }

        public void SetValue(Image other)
        {
            if (!other) { return; }

            if (Info == null)
            {
                Info = other.Info;
            }
            else if (other.Info != null)
            {
                Info.SetValue(other.Info);
            }

            if (Data == null)
            {
                Data = other.Data;
            }
            else if (other.Data != null)
            {
                Data.SetValue(other.Data);
            }
            Raise();
        }

        public Avikom.Types.Vision.Image GetValue()
        {
            var proto = new Avikom.Types.Vision.Image();
            proto.Info = Info?.GetValue() ?? proto.Info;
            proto.Data = (Data != null) ? ByteString.CopyFrom(Data.GetValue(), 0, Data.GetValue().Length) : proto.Data;
            return proto;
        }
    }

}

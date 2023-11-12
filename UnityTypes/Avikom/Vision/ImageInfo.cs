
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Vision
{

    /** This message is a header for image data transfer in chunks.
     It should always be set in the first `Image` message send to an image receiver.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/ImageInfo")]
    public class ImageInfo : GameEvent<ImageInfo>, IGameEvent
    {
        public static Avikom.Types.Vision.ImageInfo TypeDefault = null;
        // size of the image in bytes
        public IntVariable Size;

        // transfer chunk size in bytes
        public IntVariable ChunkSize;

        // whether the image has been compressed or send raw; NOTE: this field is not considered right now by the `ImageService`
        public BoolVariable Compressed;

        // pixel width of the image
        public IntVariable Width;

        // pixel height of the image
        public IntVariable Height;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Vision.ImageInfo proto)
        {

            if (Size == null) { Size = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Size != IntVariable.TypeDefault)
            {
                Size.SetValue(proto.Size);
            }

            if (ChunkSize == null) { ChunkSize = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.ChunkSize != IntVariable.TypeDefault)
            {
                ChunkSize.SetValue(proto.ChunkSize);
            }

            if (Compressed == null) { Compressed = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Compressed.SetValue(proto.Compressed);
            }

            if (Width == null) { Width = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Width != IntVariable.TypeDefault)
            {
                Width.SetValue(proto.Width);
            }

            if (Height == null) { Height = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Height != IntVariable.TypeDefault)
            {
                Height.SetValue(proto.Height);
            }
            Raise();
        }

        public void SetValue(ImageInfo other)
        {
            if (!other) { return; }

            if (Size == null)
            {
                Size = other.Size;
            }
            else if (other.Size != null)
            {
                Size.SetValue(other.Size);
            }

            if (ChunkSize == null)
            {
                ChunkSize = other.ChunkSize;
            }
            else if (other.ChunkSize != null)
            {
                ChunkSize.SetValue(other.ChunkSize);
            }

            if (Compressed == null)
            {
                Compressed = other.Compressed;
            }
            else if (other.Compressed != null)
            {
                Compressed.SetValue(other.Compressed);
            }

            if (Width == null)
            {
                Width = other.Width;
            }
            else if (other.Width != null)
            {
                Width.SetValue(other.Width);
            }

            if (Height == null)
            {
                Height = other.Height;
            }
            else if (other.Height != null)
            {
                Height.SetValue(other.Height);
            }
            Raise();
        }

        public Avikom.Types.Vision.ImageInfo GetValue()
        {
            var proto = new Avikom.Types.Vision.ImageInfo();
            proto.Size = Size?.GetValue() ?? proto.Size;
            proto.ChunkSize = ChunkSize?.GetValue() ?? proto.ChunkSize;
            proto.Compressed = Compressed?.GetValue() ?? proto.Compressed;
            proto.Width = Width?.GetValue() ?? proto.Width;
            proto.Height = Height?.GetValue() ?? proto.Height;
            return proto;
        }
    }

}

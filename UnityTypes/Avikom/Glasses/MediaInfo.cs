
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Glasses
{

    /** This message describes a media file, it's name (or file path), its content type (e.g. video, audio, image) and the current playback time if applicable.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/MediaInfo")]
    public class MediaInfo : GameEvent<MediaInfo>, IGameEvent
    {
        public static Avikom.Types.Glasses.MediaInfo TypeDefault = null;
        // media name, identifier or file path
        public StringVariable MediaName;

        // the content type, e.g. video, image or audio
        public Avikom.UnityTypes.Generic.ContentType ContentType;

        // the current playback time location; not applicable for images etc.
        public UnsignedIntVariable Milliseconds;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Glasses.MediaInfo proto)
        {

            if (MediaName == null) { MediaName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.MediaName != StringVariable.TypeDefault)
            {
                MediaName.SetValue(proto.MediaName);
            }

            if (ContentType == null) { ContentType = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.ContentType>(); }
            if (proto.ContentType != Avikom.UnityTypes.Generic.ContentType.TypeDefault)
            {
                ContentType.SetValue(proto.ContentType);
            }

            if (Milliseconds == null) { Milliseconds = ScriptableObject.CreateInstance<UnsignedIntVariable>(); }
            if (proto.Milliseconds != UnsignedIntVariable.TypeDefault)
            {
                Milliseconds.SetValue(proto.Milliseconds);
            }
            Raise();
        }

        public void SetValue(MediaInfo other)
        {
            if (!other) { return; }

            if (MediaName == null)
            {
                MediaName = other.MediaName;
            }
            else if (other.MediaName != null)
            {
                MediaName.SetValue(other.MediaName);
            }

            if (ContentType == null)
            {
                ContentType = other.ContentType;
            }
            else if (other.ContentType != null)
            {
                ContentType.SetValue(other.ContentType);
            }

            if (Milliseconds == null)
            {
                Milliseconds = other.Milliseconds;
            }
            else if (other.Milliseconds != null)
            {
                Milliseconds.SetValue(other.Milliseconds);
            }
            Raise();
        }

        public Avikom.Types.Glasses.MediaInfo GetValue()
        {
            var proto = new Avikom.Types.Glasses.MediaInfo();
            proto.MediaName = MediaName?.GetValue() ?? proto.MediaName;
            proto.ContentType = ContentType?.GetValue() ?? proto.ContentType;
            proto.Milliseconds = Milliseconds?.GetValue() ?? proto.Milliseconds;
            return proto;
        }
    }

}

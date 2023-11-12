
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** The actual value of a media instruction. Only one field should be set.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionMediaValue")]
    public class InstructionMediaValue : GameEvent<InstructionMediaValue>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionMediaValue TypeDefault = null;
        // a local ressource identifier; resolution is receiver-specific
        public StringVariable Uri;

        // a global reference to a ressource; should be taken literally
        public StringVariable Url;

        // the media file as a data stream
        public ByteArrayVariable Data;

        // type hint for this media value
        public Avikom.UnityTypes.Assistance.MediaType Type;

        // determines whether a media file should be looped (if playable)
        public BoolVariable Looped;

        // determines whether a media file should be opened/executed right away
        public BoolVariable Autoplay;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionMediaValue proto)
        {

            if (Uri == null) { Uri = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Uri != StringVariable.TypeDefault)
            {
                Uri.SetValue(proto.Uri);
            }

            if (Url == null) { Url = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Url != StringVariable.TypeDefault)
            {
                Url.SetValue(proto.Url);
            }

            if (Data == null) { Data = ScriptableObject.CreateInstance<ByteArrayVariable>(); }
            if (!proto.Data.IsEmpty)
            {
                Data.SetValue(proto.Data.ToByteArray());
            }

            if (Type == null) { Type = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.MediaType>(); }
            if (proto.Type != Avikom.UnityTypes.Assistance.MediaType.TypeDefault)
            {
                Type.SetValue(proto.Type);
            }

            if (Looped == null) { Looped = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Looped.SetValue(proto.Looped);
            }

            if (Autoplay == null) { Autoplay = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Autoplay.SetValue(proto.Autoplay);
            }
            Raise();
        }

        public void SetValue(InstructionMediaValue other)
        {
            if (!other) { return; }

            if (Uri == null)
            {
                Uri = other.Uri;
            }
            else if (other.Uri != null)
            {
                Uri.SetValue(other.Uri);
            }

            if (Url == null)
            {
                Url = other.Url;
            }
            else if (other.Url != null)
            {
                Url.SetValue(other.Url);
            }

            if (Data == null)
            {
                Data = other.Data;
            }
            else if (other.Data != null)
            {
                Data.SetValue(other.Data);
            }

            if (Type == null)
            {
                Type = other.Type;
            }
            else if (other.Type != null)
            {
                Type.SetValue(other.Type);
            }

            if (Looped == null)
            {
                Looped = other.Looped;
            }
            else if (other.Looped != null)
            {
                Looped.SetValue(other.Looped);
            }

            if (Autoplay == null)
            {
                Autoplay = other.Autoplay;
            }
            else if (other.Autoplay != null)
            {
                Autoplay.SetValue(other.Autoplay);
            }
            Raise();
        }

        public Avikom.Types.Assistance.InstructionMediaValue GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionMediaValue();
            proto.Uri = Uri?.GetValue() ?? proto.Uri;
            proto.Url = Url?.GetValue() ?? proto.Url;
            proto.Data = (Data != null) ? ByteString.CopyFrom(Data.GetValue(), 0, Data.GetValue().Length) : proto.Data;
            proto.Type = Type?.GetValue() ?? proto.Type;
            proto.Looped = Looped?.GetValue() ?? proto.Looped;
            proto.Autoplay = Autoplay?.GetValue() ?? proto.Autoplay;
            return proto;
        }
    }

}

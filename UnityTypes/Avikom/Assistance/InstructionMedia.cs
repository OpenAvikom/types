
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a media instruction. This includes the instruction's (MIME) type and either an URI or the media as a binary stream.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionMedia")]
    public class InstructionMedia : GameEvent<InstructionMedia>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionMedia TypeDefault = null;

        public Avikom.UnityTypes.Assistance.InstructionMeta Meta;


        public Avikom.UnityTypes.Assistance.InstructionMediaValue Content;


        public Avikom.UnityTypes.Assistance.InstructionMediaValue Preview;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionMedia proto)
        {

            if (Meta == null) { Meta = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMeta>(); }
            if (proto.Meta != Avikom.UnityTypes.Assistance.InstructionMeta.TypeDefault)
            {
                Meta.SetValue(proto.Meta);
            }

            if (Content == null) { Content = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMediaValue>(); }
            if (proto.Content != Avikom.UnityTypes.Assistance.InstructionMediaValue.TypeDefault)
            {
                Content.SetValue(proto.Content);
            }

            if (Preview == null) { Preview = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMediaValue>(); }
            if (proto.Preview != Avikom.UnityTypes.Assistance.InstructionMediaValue.TypeDefault)
            {
                Preview.SetValue(proto.Preview);
            }
            Raise();
        }

        public void SetValue(InstructionMedia other)
        {
            if (!other) { return; }

            if (Meta == null)
            {
                Meta = other.Meta;
            }
            else if (other.Meta != null)
            {
                Meta.SetValue(other.Meta);
            }

            if (Content == null)
            {
                Content = other.Content;
            }
            else if (other.Content != null)
            {
                Content.SetValue(other.Content);
            }

            if (Preview == null)
            {
                Preview = other.Preview;
            }
            else if (other.Preview != null)
            {
                Preview.SetValue(other.Preview);
            }
            Raise();
        }

        public Avikom.Types.Assistance.InstructionMedia GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionMedia();
            proto.Meta = Meta?.GetValue() ?? proto.Meta;
            proto.Content = Content?.GetValue() ?? proto.Content;
            proto.Preview = Preview?.GetValue() ?? proto.Preview;
            return proto;
        }
    }

}

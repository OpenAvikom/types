
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message should be used for textual instruction that can be displayed or spoken.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionText")]
    public class InstructionText : GameEvent<InstructionText>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionText TypeDefault = null;
        // context information for the instruction
        public Avikom.UnityTypes.Assistance.InstructionMeta Meta;

        // styling hints for the text instruction
        public Avikom.UnityTypes.Assistance.ContentStyle ContentStyle;

        // the runtime value of an instruction, can include moustache fields
        public Avikom.UnityTypes.Assistance.InstructionTextValue Content;

        // optional field which will be shown during step preview; must not contain dynamic content
        public Avikom.UnityTypes.Assistance.InstructionTextValue Preview;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionText proto)
        {

            if (Meta == null) { Meta = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMeta>(); }
            if (proto.Meta != Avikom.UnityTypes.Assistance.InstructionMeta.TypeDefault)
            {
                Meta.SetValue(proto.Meta);
            }

            if (ContentStyle == null) { ContentStyle = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ContentStyle>(); }
            if (proto.ContentStyle != Avikom.UnityTypes.Assistance.ContentStyle.TypeDefault)
            {
                ContentStyle.SetValue(proto.ContentStyle);
            }

            if (Content == null) { Content = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionTextValue>(); }
            if (proto.Content != Avikom.UnityTypes.Assistance.InstructionTextValue.TypeDefault)
            {
                Content.SetValue(proto.Content);
            }

            if (Preview == null) { Preview = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionTextValue>(); }
            if (proto.Preview != Avikom.UnityTypes.Assistance.InstructionTextValue.TypeDefault)
            {
                Preview.SetValue(proto.Preview);
            }
            Raise();
        }

        public void SetValue(InstructionText other)
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

            if (ContentStyle == null)
            {
                ContentStyle = other.ContentStyle;
            }
            else if (other.ContentStyle != null)
            {
                ContentStyle.SetValue(other.ContentStyle);
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

        public Avikom.Types.Assistance.InstructionText GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionText();
            proto.Meta = Meta?.GetValue() ?? proto.Meta;
            proto.ContentStyle = ContentStyle?.GetValue() ?? proto.ContentStyle;
            proto.Content = Content?.GetValue() ?? proto.Content;
            proto.Preview = Preview?.GetValue() ?? proto.Preview;
            return proto;
        }
    }

}


using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** The actual value of a text instruction in different representations
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionTextValue")]
    public class InstructionTextValue : GameEvent<InstructionTextValue>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionTextValue TypeDefault = null;
        // value as plain text
        public StringVariable Plain;

        // value with Speech Synthesis Markup Language annotation
        public StringVariable Ssml;

        // value with HTML annotation
        public StringVariable Html;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionTextValue proto)
        {

            if (Plain == null) { Plain = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Plain != StringVariable.TypeDefault)
            {
                Plain.SetValue(proto.Plain);
            }

            if (Ssml == null) { Ssml = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Ssml != StringVariable.TypeDefault)
            {
                Ssml.SetValue(proto.Ssml);
            }

            if (Html == null) { Html = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Html != StringVariable.TypeDefault)
            {
                Html.SetValue(proto.Html);
            }
            Raise();
        }

        public void SetValue(InstructionTextValue other)
        {
            if (!other) { return; }

            if (Plain == null)
            {
                Plain = other.Plain;
            }
            else if (other.Plain != null)
            {
                Plain.SetValue(other.Plain);
            }

            if (Ssml == null)
            {
                Ssml = other.Ssml;
            }
            else if (other.Ssml != null)
            {
                Ssml.SetValue(other.Ssml);
            }

            if (Html == null)
            {
                Html = other.Html;
            }
            else if (other.Html != null)
            {
                Html.SetValue(other.Html);
            }
            Raise();
        }

        public Avikom.Types.Assistance.InstructionTextValue GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionTextValue();
            proto.Plain = Plain?.GetValue() ?? proto.Plain;
            proto.Ssml = Ssml?.GetValue() ?? proto.Ssml;
            proto.Html = Html?.GetValue() ?? proto.Html;
            return proto;
        }
    }

}

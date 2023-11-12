
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A request that either includes a standardized utterance or custom output to be played back via TTS. 
     The output is queued with other speech output.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/SayRequest")]
    public class SayRequest : GameEvent<SayRequest>, IGameEvent
    {
        public static Avikom.Types.Headset.SayRequest TypeDefault = null;
        // a string representation of what should be generated as speech
        public StringVariable Utterance;

        // a set of predefined speech outputs
        public Avikom.UnityTypes.Headset.CommonUtterance CommonUtterance;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.SayRequest proto)
        {

            if (Utterance == null) { Utterance = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Utterance != StringVariable.TypeDefault)
            {
                Utterance.SetValue(proto.Utterance);
            }

            if (CommonUtterance == null) { CommonUtterance = ScriptableObject.CreateInstance<Avikom.UnityTypes.Headset.CommonUtterance>(); }
            if (proto.CommonUtterance != Avikom.UnityTypes.Headset.CommonUtterance.TypeDefault)
            {
                CommonUtterance.SetValue(proto.CommonUtterance);
            }
            Raise();
        }

        public void SetValue(SayRequest other)
        {
            if (!other) { return; }

            if (Utterance == null)
            {
                Utterance = other.Utterance;
            }
            else if (other.Utterance != null)
            {
                Utterance.SetValue(other.Utterance);
            }

            if (CommonUtterance == null)
            {
                CommonUtterance = other.CommonUtterance;
            }
            else if (other.CommonUtterance != null)
            {
                CommonUtterance.SetValue(other.CommonUtterance);
            }
            Raise();
        }

        public Avikom.Types.Headset.SayRequest GetValue()
        {
            var proto = new Avikom.Types.Headset.SayRequest();
            proto.Utterance = Utterance?.GetValue() ?? proto.Utterance;
            proto.CommonUtterance = CommonUtterance?.GetValue() ?? proto.CommonUtterance;
            return proto;
        }
    }

}

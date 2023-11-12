
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A RasaMessage provides the intents and slots recognized by rasa for a specific user.
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/RasaMessage")]
    public class RasaMessage : GameEvent<RasaMessage>, IGameEvent
    {
        public static Avikom.Types.Headset.RasaMessage TypeDefault = null;
        // the recognized intention of the user input
        public StringVariable Intent;

        // additional information extracted from user input as key-value pairs
        public Avikom.UnityTypes.Generic.KeyValuePair Slots;

        // the user who provided the input
        public UnsignedLongVariable UserId;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.RasaMessage proto)
        {

            if (Intent == null) { Intent = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Intent != StringVariable.TypeDefault)
            {
                Intent.SetValue(proto.Intent);
            }

            if (Slots == null) { Slots = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePair>(); }
            if (proto.Slots != Avikom.UnityTypes.Generic.KeyValuePair.TypeDefault)
            {
                Slots.SetValue(proto.Slots);
            }

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.UserId != UnsignedLongVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }
            Raise();
        }

        public void SetValue(RasaMessage other)
        {
            if (!other) { return; }

            if (Intent == null)
            {
                Intent = other.Intent;
            }
            else if (other.Intent != null)
            {
                Intent.SetValue(other.Intent);
            }

            if (Slots == null)
            {
                Slots = other.Slots;
            }
            else if (other.Slots != null)
            {
                Slots.SetValue(other.Slots);
            }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }
            Raise();
        }

        public Avikom.Types.Headset.RasaMessage GetValue()
        {
            var proto = new Avikom.Types.Headset.RasaMessage();
            proto.Intent = Intent?.GetValue() ?? proto.Intent;
            proto.Slots = Slots?.GetValue() ?? proto.Slots;
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            return proto;
        }
    }

}

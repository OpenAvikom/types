
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** This message is used to transfer associated information (i.e. slots extracted by rasa). 
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/KeyValuePair")]
    public class KeyValuePair : GameEvent<KeyValuePair>, IGameEvent
    {
        public static Avikom.Types.Generic.KeyValuePair TypeDefault = null;
        // defines the value data type; informs consumer how to parse value
        public StringVariable Key;

        // value holds information serialized as string and needs to be parsed by consumer
        public StringVariable Value;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.KeyValuePair proto)
        {

            if (Key == null) { Key = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Key != StringVariable.TypeDefault)
            {
                Key.SetValue(proto.Key);
            }

            if (Value == null) { Value = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Value != StringVariable.TypeDefault)
            {
                Value.SetValue(proto.Value);
            }
            Raise();
        }

        public void SetValue(KeyValuePair other)
        {
            if (!other) { return; }

            if (Key == null)
            {
                Key = other.Key;
            }
            else if (other.Key != null)
            {
                Key.SetValue(other.Key);
            }

            if (Value == null)
            {
                Value = other.Value;
            }
            else if (other.Value != null)
            {
                Value.SetValue(other.Value);
            }
            Raise();
        }

        public Avikom.Types.Generic.KeyValuePair GetValue()
        {
            var proto = new Avikom.Types.Generic.KeyValuePair();
            proto.Key = Key?.GetValue() ?? proto.Key;
            proto.Value = Value?.GetValue() ?? proto.Value;
            return proto;
        }
    }

}

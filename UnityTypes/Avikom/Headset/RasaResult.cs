
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A list containing intents.
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/RasaResult")]
    public class RasaResult : GameEvent<RasaResult>, IGameEvent
    {
        public static Avikom.Types.Headset.RasaResult TypeDefault = null;
        // a list of intents that can be used to resolve task steps
        public StringVariable Intents;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.RasaResult proto)
        {

            if (Intents == null) { Intents = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Intents != StringVariable.TypeDefault)
            {
                Intents.SetValue(proto.Intents);
            }
            Raise();
        }

        public void SetValue(RasaResult other)
        {
            if (!other) { return; }

            if (Intents == null)
            {
                Intents = other.Intents;
            }
            else if (other.Intents != null)
            {
                Intents.SetValue(other.Intents);
            }
            Raise();
        }

        public Avikom.Types.Headset.RasaResult GetValue()
        {
            var proto = new Avikom.Types.Headset.RasaResult();
            proto.Intents = Intents?.GetValue() ?? proto.Intents;
            return proto;
        }
    }

}

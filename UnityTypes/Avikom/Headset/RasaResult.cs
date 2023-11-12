
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
        public StringVariableSet Intents;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.RasaResult proto)
        {

            if (Intents == null) { Intents = ScriptableObject.CreateInstance<StringVariableSet>(); }
            if (proto.Intents.Count > 0)
            {
                Intents.Clear();
                foreach (var value in proto.Intents)
                {
                    var tmp = ScriptableObject.CreateInstance<StringVariable>();
                    tmp.SetValue(value);
                    Intents.Add(tmp);
                }
                Intents.Raise();
            }
        
            Raise();
        }

        public void SetValue(RasaResult other)
        {
            if (!other) { return; }

            if (other.Intents != null)
            {
                if (Intents == null) { Intents = ScriptableObject.CreateInstance<StringVariableSet>(); }
                Intents.Clear();
                foreach (var elem in other.Intents.Items)
                {
                    Intents.Add(elem);
                }
                Intents.Raise();
            }
            Raise();
        }

        public Avikom.Types.Headset.RasaResult GetValue()
        {
            var proto = new Avikom.Types.Headset.RasaResult();

            foreach (var value in Intents.Items) { proto.Intents.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

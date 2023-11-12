
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A message that combines peer topics and related service configurations meant for TaskStep definitions.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ServiceConfiguration")]
    public class ServiceConfiguration : GameEvent<ServiceConfiguration>, IGameEvent
    {
        public static Avikom.Types.Assistance.ServiceConfiguration TypeDefault = null;
        // topic related to this service
        public StringVariable Topic;

        // key-value pairs to configure the requested service
        public Avikom.UnityTypes.Generic.KeyValuePairSet Parameters;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.ServiceConfiguration proto)
        {

            if (Topic == null) { Topic = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Topic != StringVariable.TypeDefault)
            {
                Topic.SetValue(proto.Topic);
            }

            if (Parameters == null) { Parameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
            if (proto.Parameters.Count > 0)
            {
                Parameters.Clear();
                foreach (var value in proto.Parameters)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePair>();
                    tmp.SetValue(value);
                    Parameters.Add(tmp);
                }
                Parameters.Raise();
            }
        
            Raise();
        }

        public void SetValue(ServiceConfiguration other)
        {
            if (!other) { return; }

            if (Topic == null)
            {
                Topic = other.Topic;
            }
            else if (other.Topic != null)
            {
                Topic.SetValue(other.Topic);
            }

            if (other.Parameters != null)
            {
                if (Parameters == null) { Parameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
                Parameters.Clear();
                foreach (var elem in other.Parameters.Items)
                {
                    Parameters.Add(elem);
                }
                Parameters.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.ServiceConfiguration GetValue()
        {
            var proto = new Avikom.Types.Assistance.ServiceConfiguration();
            proto.Topic = Topic?.GetValue() ?? proto.Topic;

            foreach (var value in Parameters.Items) { proto.Parameters.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

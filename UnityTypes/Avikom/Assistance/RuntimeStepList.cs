
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of `RuntimeTaskSteps`. It also contains a list of `Peers` which can be used to conduct the passed steps.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepList")]
    public class RuntimeStepList : GameEvent<RuntimeStepList>, IGameEvent
    {
        public static Avikom.Types.Assistance.RuntimeStepList TypeDefault = null;
        // currently active task steps to be done
        public Avikom.UnityTypes.Assistance.RuntimeTaskStepSet Steps;

        // a list of peers that can be used to solve task steps
        public Avikom.UnityTypes.Generic.PeerSet Peers;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.RuntimeStepList proto)
        {

            if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.RuntimeTaskStepSet>(); }
            if (proto.Steps.Count > 0)
            {
                Steps.Clear();
                foreach (var value in proto.Steps)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.RuntimeTaskStep>();
                    tmp.SetValue(value);
                    Steps.Add(tmp);
                }
                Steps.Raise();
            }
        

            if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.PeerSet>(); }
            if (proto.Peers.Count > 0)
            {
                Peers.Clear();
                foreach (var value in proto.Peers)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>();
                    tmp.SetValue(value);
                    Peers.Add(tmp);
                }
                Peers.Raise();
            }
        
            Raise();
        }

        public void SetValue(RuntimeStepList other)
        {
            if (!other) { return; }

            if (other.Steps != null)
            {
                if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.RuntimeTaskStepSet>(); }
                Steps.Clear();
                foreach (var elem in other.Steps.Items)
                {
                    Steps.Add(elem);
                }
                Steps.Raise();
            }

            if (other.Peers != null)
            {
                if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.PeerSet>(); }
                Peers.Clear();
                foreach (var elem in other.Peers.Items)
                {
                    Peers.Add(elem);
                }
                Peers.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.RuntimeStepList GetValue()
        {
            var proto = new Avikom.Types.Assistance.RuntimeStepList();

            foreach (var value in Steps.Items) { proto.Steps.Add(value.GetValue()); }
                        

            foreach (var value in Peers.Items) { proto.Peers.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

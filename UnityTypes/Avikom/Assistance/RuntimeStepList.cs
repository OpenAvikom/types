
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
        public Avikom.UnityTypes.Assistance.RuntimeTaskStep Steps;

        // a list of peers that can be used to solve task steps
        public Avikom.UnityTypes.Generic.Peer Peers;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.RuntimeStepList proto)
        {

            if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.RuntimeTaskStep>(); }
            if (proto.Steps != Avikom.UnityTypes.Assistance.RuntimeTaskStep.TypeDefault)
            {
                Steps.SetValue(proto.Steps);
            }

            if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>(); }
            if (proto.Peers != Avikom.UnityTypes.Generic.Peer.TypeDefault)
            {
                Peers.SetValue(proto.Peers);
            }
            Raise();
        }

        public void SetValue(RuntimeStepList other)
        {
            if (!other) { return; }

            if (Steps == null)
            {
                Steps = other.Steps;
            }
            else if (other.Steps != null)
            {
                Steps.SetValue(other.Steps);
            }

            if (Peers == null)
            {
                Peers = other.Peers;
            }
            else if (other.Peers != null)
            {
                Peers.SetValue(other.Peers);
            }
            Raise();
        }

        public Avikom.Types.Assistance.RuntimeStepList GetValue()
        {
            var proto = new Avikom.Types.Assistance.RuntimeStepList();
            proto.Steps = Steps?.GetValue() ?? proto.Steps;
            proto.Peers = Peers?.GetValue() ?? proto.Peers;
            return proto;
        }
    }

}

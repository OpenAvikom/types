
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A message that combines the `RuntimeTaskStep` id and the state update.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepStateChange")]
    public class RuntimeStepStateChange : GameEvent<RuntimeStepStateChange>, IGameEvent
    {
        public static Avikom.Types.Assistance.RuntimeStepStateChange TypeDefault = null;
        // The RTS id
        public StringVariable Id;

        // The new state of the RTS
        public Avikom.UnityTypes.Assistance.RuntimeStepState State;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.RuntimeStepStateChange proto)
        {

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (State == null) { State = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.RuntimeStepState>(); }
            if (proto.State != Avikom.UnityTypes.Assistance.RuntimeStepState.TypeDefault)
            {
                State.SetValue(proto.State);
            }
            Raise();
        }

        public void SetValue(RuntimeStepStateChange other)
        {
            if (!other) { return; }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }

            if (State == null)
            {
                State = other.State;
            }
            else if (other.State != null)
            {
                State.SetValue(other.State);
            }
            Raise();
        }

        public Avikom.Types.Assistance.RuntimeStepStateChange GetValue()
        {
            var proto = new Avikom.Types.Assistance.RuntimeStepStateChange();
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.State = State?.GetValue() ?? proto.State;
            return proto;
        }
    }

}

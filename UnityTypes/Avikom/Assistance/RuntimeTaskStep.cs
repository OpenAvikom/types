
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** Adds runtime-specific (temporal) data to a (static) TaskStep
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeTaskStep")]
    public class RuntimeTaskStep : GameEvent<RuntimeTaskStep>, IGameEvent
    {
        public static Avikom.Types.Assistance.RuntimeTaskStep TypeDefault = null;
        // the task defintion; fields have been dynamically altered and contain context-specific values
        public Avikom.UnityTypes.Assistance.TaskStep Step;

        // a unique key to define this particular RTS instance
        public StringVariable Id;

        // current state of the runtime task step
        public Avikom.UnityTypes.Assistance.RuntimeStepState State;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.RuntimeTaskStep proto)
        {

            if (Step == null) { Step = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStep>(); }
            if (proto.Step != Avikom.UnityTypes.Assistance.TaskStep.TypeDefault)
            {
                Step.SetValue(proto.Step);
            }

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

        public void SetValue(RuntimeTaskStep other)
        {
            if (!other) { return; }

            if (Step == null)
            {
                Step = other.Step;
            }
            else if (other.Step != null)
            {
                Step.SetValue(other.Step);
            }

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

        public Avikom.Types.Assistance.RuntimeTaskStep GetValue()
        {
            var proto = new Avikom.Types.Assistance.RuntimeTaskStep();
            proto.Step = Step?.GetValue() ?? proto.Step;
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.State = State?.GetValue() ?? proto.State;
            return proto;
        }
    }

}

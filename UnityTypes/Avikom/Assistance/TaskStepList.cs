
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of task steps.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStepList")]
    public class TaskStepList : GameEvent<TaskStepList>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskStepList TypeDefault = null;
        // a task step list
        public Avikom.UnityTypes.Assistance.TaskStep Steps;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskStepList proto)
        {

            if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStep>(); }
            if (proto.Steps != Avikom.UnityTypes.Assistance.TaskStep.TypeDefault)
            {
                Steps.SetValue(proto.Steps);
            }
            Raise();
        }

        public void SetValue(TaskStepList other)
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
            Raise();
        }

        public Avikom.Types.Assistance.TaskStepList GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskStepList();
            proto.Steps = Steps?.GetValue() ?? proto.Steps;
            return proto;
        }
    }

}

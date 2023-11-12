
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** An event that should be processed by the BPM engine (Camunda) and/or AVIKOM services.
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskEvent")]
    public class TaskEvent : GameEvent<TaskEvent>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskEvent TypeDefault = null;
        // the ID of the current service task/RTS in which the event was triggered
        public StringVariable TaskId;

        // the event result/outcome; in cases of a failed task this might me an error decription
        public StringVariable Result;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskEvent proto)
        {

            if (TaskId == null) { TaskId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TaskId != StringVariable.TypeDefault)
            {
                TaskId.SetValue(proto.TaskId);
            }

            if (Result == null) { Result = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Result != StringVariable.TypeDefault)
            {
                Result.SetValue(proto.Result);
            }
            Raise();
        }

        public void SetValue(TaskEvent other)
        {
            if (!other) { return; }

            if (TaskId == null)
            {
                TaskId = other.TaskId;
            }
            else if (other.TaskId != null)
            {
                TaskId.SetValue(other.TaskId);
            }

            if (Result == null)
            {
                Result = other.Result;
            }
            else if (other.Result != null)
            {
                Result.SetValue(other.Result);
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskEvent GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskEvent();
            proto.TaskId = TaskId?.GetValue() ?? proto.TaskId;
            proto.Result = Result?.GetValue() ?? proto.Result;
            return proto;
        }
    }

}

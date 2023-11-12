
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** A message to query a task configuration by `task_name`.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/TaskConfigQuery")]
    public class TaskConfigQuery : GameEvent<TaskConfigQuery>, IGameEvent
    {
        public static Avikom.Types.Unity.TaskConfigQuery TypeDefault = null;
        // name of the task
        public StringVariable TaskName;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.TaskConfigQuery proto)
        {

            if (TaskName == null) { TaskName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TaskName != StringVariable.TypeDefault)
            {
                TaskName.SetValue(proto.TaskName);
            }
            Raise();
        }

        public void SetValue(TaskConfigQuery other)
        {
            if (!other) { return; }

            if (TaskName == null)
            {
                TaskName = other.TaskName;
            }
            else if (other.TaskName != null)
            {
                TaskName.SetValue(other.TaskName);
            }
            Raise();
        }

        public Avikom.Types.Unity.TaskConfigQuery GetValue()
        {
            var proto = new Avikom.Types.Unity.TaskConfigQuery();
            proto.TaskName = TaskName?.GetValue() ?? proto.TaskName;
            return proto;
        }
    }

}

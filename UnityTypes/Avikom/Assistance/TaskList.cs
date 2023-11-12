
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of tasks.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskList")]
    public class TaskList : GameEvent<TaskList>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskList TypeDefault = null;
        // a task list
        public Avikom.UnityTypes.Assistance.Task Tasks;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskList proto)
        {

            if (Tasks == null) { Tasks = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Task>(); }
            if (proto.Tasks != Avikom.UnityTypes.Assistance.Task.TypeDefault)
            {
                Tasks.SetValue(proto.Tasks);
            }
            Raise();
        }

        public void SetValue(TaskList other)
        {
            if (!other) { return; }

            if (Tasks == null)
            {
                Tasks = other.Tasks;
            }
            else if (other.Tasks != null)
            {
                Tasks.SetValue(other.Tasks);
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskList GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskList();
            proto.Tasks = Tasks?.GetValue() ?? proto.Tasks;
            return proto;
        }
    }

}

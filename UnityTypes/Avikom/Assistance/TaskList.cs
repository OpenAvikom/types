
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
        public Avikom.UnityTypes.Assistance.TaskSet Tasks;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskList proto)
        {

            if (Tasks == null) { Tasks = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskSet>(); }
            if (proto.Tasks.Count > 0)
            {
                Tasks.Clear();
                foreach (var value in proto.Tasks)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Task>();
                    tmp.SetValue(value);
                    Tasks.Add(tmp);
                }
                Tasks.Raise();
            }
        
            Raise();
        }

        public void SetValue(TaskList other)
        {
            if (!other) { return; }

            if (other.Tasks != null)
            {
                if (Tasks == null) { Tasks = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskSet>(); }
                Tasks.Clear();
                foreach (var elem in other.Tasks.Items)
                {
                    Tasks.Add(elem);
                }
                Tasks.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskList GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskList();

            foreach (var value in Tasks.Items) { proto.Tasks.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

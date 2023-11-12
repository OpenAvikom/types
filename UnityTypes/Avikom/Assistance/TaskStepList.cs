
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
        public Avikom.UnityTypes.Assistance.TaskStepSet Steps;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskStepList proto)
        {

            if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStepSet>(); }
            if (proto.Steps.Count > 0)
            {
                Steps.Clear();
                foreach (var value in proto.Steps)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStep>();
                    tmp.SetValue(value);
                    Steps.Add(tmp);
                }
                Steps.Raise();
            }
        
            Raise();
        }

        public void SetValue(TaskStepList other)
        {
            if (!other) { return; }

            if (other.Steps != null)
            {
                if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStepSet>(); }
                Steps.Clear();
                foreach (var elem in other.Steps.Items)
                {
                    Steps.Add(elem);
                }
                Steps.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskStepList GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskStepList();

            foreach (var value in Steps.Items) { proto.Steps.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

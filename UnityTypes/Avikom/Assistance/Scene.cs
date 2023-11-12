
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** Describes the location/context of a task. This might be an office or a lab.
     The `tasks` field should only contain tasks that can be intialized without further information.
     For instance, when a task requires to be prepened by another task, it should be mentioned here.
     Thus, an `Issue` might contain a task that is not mentioned in `Session.tasks`.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/Scene")]
    public class Scene : GameEvent<Scene>, IGameEvent
    {
        public static Avikom.Types.Assistance.Scene TypeDefault = null;
        // a unique name for the location/context
        public StringVariable Name;

        // all the tasks that can be conducted without further information
        public Avikom.UnityTypes.Assistance.TaskSet Tasks;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.Scene proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

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

        public void SetValue(Scene other)
        {
            if (!other) { return; }

            if (Name == null)
            {
                Name = other.Name;
            }
            else if (other.Name != null)
            {
                Name.SetValue(other.Name);
            }

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

        public Avikom.Types.Assistance.Scene GetValue()
        {
            var proto = new Avikom.Types.Assistance.Scene();
            proto.Name = Name?.GetValue() ?? proto.Name;

            foreach (var value in Tasks.Items) { proto.Tasks.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

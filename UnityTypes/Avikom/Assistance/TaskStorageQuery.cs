
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A query to retrieve a scene, task or task step via its name.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStorageQuery")]
    public class TaskStorageQuery : GameEvent<TaskStorageQuery>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskStorageQuery TypeDefault = null;
        // name of a scene, task or task step
        public StringVariable Name;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskStorageQuery proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }
            Raise();
        }

        public void SetValue(TaskStorageQuery other)
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
            Raise();
        }

        public Avikom.Types.Assistance.TaskStorageQuery GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskStorageQuery();
            proto.Name = Name?.GetValue() ?? proto.Name;
            return proto;
        }
    }

}

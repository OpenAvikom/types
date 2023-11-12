
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** This message describes a task config and contains context-specific objects.
     All assets should have a parent that represents their location within a scene.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/TaskConfig")]
    public class TaskConfig : GameEvent<TaskConfig>, IGameEvent
    {
        public static Avikom.Types.Unity.TaskConfig TypeDefault = null;
        // name of the task that is configured
        public StringVariable TaskName;

        // a list of assets that represent (virtual) task-specific assets
        public Avikom.UnityTypes.Unity.GameObjectSet Assets;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.TaskConfig proto)
        {

            if (TaskName == null) { TaskName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TaskName != StringVariable.TypeDefault)
            {
                TaskName.SetValue(proto.TaskName);
            }

            if (Assets == null) { Assets = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
            if (proto.Assets.Count > 0)
            {
                Assets.Clear();
                foreach (var value in proto.Assets)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObject>();
                    tmp.SetValue(value);
                    Assets.Add(tmp);
                }
                Assets.Raise();
            }
        
            Raise();
        }

        public void SetValue(TaskConfig other)
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

            if (other.Assets != null)
            {
                if (Assets == null) { Assets = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
                Assets.Clear();
                foreach (var elem in other.Assets.Items)
                {
                    Assets.Add(elem);
                }
                Assets.Raise();
            }
            Raise();
        }

        public Avikom.Types.Unity.TaskConfig GetValue()
        {
            var proto = new Avikom.Types.Unity.TaskConfig();
            proto.TaskName = TaskName?.GetValue() ?? proto.TaskName;

            foreach (var value in Assets.Items) { proto.Assets.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
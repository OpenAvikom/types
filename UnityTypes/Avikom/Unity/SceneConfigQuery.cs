
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** A message to query a scene configuration by `scene_name`.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/SceneConfigQuery")]
    public class SceneConfigQuery : GameEvent<SceneConfigQuery>, IGameEvent
    {
        public static Avikom.Types.Unity.SceneConfigQuery TypeDefault = null;
        // name of the scene
        public StringVariable SceneName;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.SceneConfigQuery proto)
        {

            if (SceneName == null) { SceneName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SceneName != StringVariable.TypeDefault)
            {
                SceneName.SetValue(proto.SceneName);
            }
            Raise();
        }

        public void SetValue(SceneConfigQuery other)
        {
            if (!other) { return; }

            if (SceneName == null)
            {
                SceneName = other.SceneName;
            }
            else if (other.SceneName != null)
            {
                SceneName.SetValue(other.SceneName);
            }
            Raise();
        }

        public Avikom.Types.Unity.SceneConfigQuery GetValue()
        {
            var proto = new Avikom.Types.Unity.SceneConfigQuery();
            proto.SceneName = SceneName?.GetValue() ?? proto.SceneName;
            return proto;
        }
    }

}


using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** This message describes a scene config and contains location-bound parameters.
     It should also provide semantic anchors for task-specific configurations to be attached. 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/SceneConfig")]
    public class SceneConfig : GameEvent<SceneConfig>, IGameEvent
    {
        public static Avikom.Types.Unity.SceneConfig TypeDefault = null;
        // name of the scene the configuration belongs to
        public StringVariable SceneName;

        // marked locations that synchronize the real and virtual environment; most likely QR codes
        public Avikom.UnityTypes.Unity.GameObject Anchors;

        // objects that are positioned in the scene; may act as anchors for task-specific configurations
        public Avikom.UnityTypes.Unity.GameObject Assets;

        // coordinates that represents paths from one asset to antother. used to mark 'save' guidance routes
        public Avikom.UnityTypes.Unity.Waypoint Waypoints;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.SceneConfig proto)
        {

            if (SceneName == null) { SceneName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SceneName != StringVariable.TypeDefault)
            {
                SceneName.SetValue(proto.SceneName);
            }

            if (Anchors == null) { Anchors = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObject>(); }
            if (proto.Anchors != Avikom.UnityTypes.Unity.GameObject.TypeDefault)
            {
                Anchors.SetValue(proto.Anchors);
            }

            if (Assets == null) { Assets = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObject>(); }
            if (proto.Assets != Avikom.UnityTypes.Unity.GameObject.TypeDefault)
            {
                Assets.SetValue(proto.Assets);
            }

            if (Waypoints == null) { Waypoints = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.Waypoint>(); }
            if (proto.Waypoints != Avikom.UnityTypes.Unity.Waypoint.TypeDefault)
            {
                Waypoints.SetValue(proto.Waypoints);
            }
            Raise();
        }

        public void SetValue(SceneConfig other)
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

            if (Anchors == null)
            {
                Anchors = other.Anchors;
            }
            else if (other.Anchors != null)
            {
                Anchors.SetValue(other.Anchors);
            }

            if (Assets == null)
            {
                Assets = other.Assets;
            }
            else if (other.Assets != null)
            {
                Assets.SetValue(other.Assets);
            }

            if (Waypoints == null)
            {
                Waypoints = other.Waypoints;
            }
            else if (other.Waypoints != null)
            {
                Waypoints.SetValue(other.Waypoints);
            }
            Raise();
        }

        public Avikom.Types.Unity.SceneConfig GetValue()
        {
            var proto = new Avikom.Types.Unity.SceneConfig();
            proto.SceneName = SceneName?.GetValue() ?? proto.SceneName;
            proto.Anchors = Anchors?.GetValue() ?? proto.Anchors;
            proto.Assets = Assets?.GetValue() ?? proto.Assets;
            proto.Waypoints = Waypoints?.GetValue() ?? proto.Waypoints;
            return proto;
        }
    }

}

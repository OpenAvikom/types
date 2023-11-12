
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
        public Avikom.UnityTypes.Unity.GameObjectSet Anchors;

        // objects that are positioned in the scene; may act as anchors for task-specific configurations
        public Avikom.UnityTypes.Unity.GameObjectSet Assets;

        // coordinates that represents paths from one asset to antother. used to mark 'save' guidance routes
        public Avikom.UnityTypes.Unity.WaypointSet Waypoints;


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

            if (Anchors == null) { Anchors = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
            if (proto.Anchors.Count > 0)
            {
                Anchors.Clear();
                foreach (var value in proto.Anchors)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObject>();
                    tmp.SetValue(value);
                    Anchors.Add(tmp);
                }
                Anchors.Raise();
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
        

            if (Waypoints == null) { Waypoints = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.WaypointSet>(); }
            if (proto.Waypoints.Count > 0)
            {
                Waypoints.Clear();
                foreach (var value in proto.Waypoints)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.Waypoint>();
                    tmp.SetValue(value);
                    Waypoints.Add(tmp);
                }
                Waypoints.Raise();
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

            if (other.Anchors != null)
            {
                if (Anchors == null) { Anchors = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
                Anchors.Clear();
                foreach (var elem in other.Anchors.Items)
                {
                    Anchors.Add(elem);
                }
                Anchors.Raise();
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

            if (other.Waypoints != null)
            {
                if (Waypoints == null) { Waypoints = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.WaypointSet>(); }
                Waypoints.Clear();
                foreach (var elem in other.Waypoints.Items)
                {
                    Waypoints.Add(elem);
                }
                Waypoints.Raise();
            }
            Raise();
        }

        public Avikom.Types.Unity.SceneConfig GetValue()
        {
            var proto = new Avikom.Types.Unity.SceneConfig();
            proto.SceneName = SceneName?.GetValue() ?? proto.SceneName;

            foreach (var value in Anchors.Items) { proto.Anchors.Add(value.GetValue()); }
                        

            foreach (var value in Assets.Items) { proto.Assets.Add(value.GetValue()); }
                        

            foreach (var value in Waypoints.Items) { proto.Waypoints.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

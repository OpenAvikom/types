
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** This describes a point in space and its conceptual neighbours.
     Waypoints are used to savely guide users from one location to another.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/Waypoint")]
    public class Waypoint : GameEvent<Waypoint>, IGameEvent
    {
        public static Avikom.Types.Unity.Waypoint TypeDefault = null;
        // waypoint name to be adressable
        public StringVariable Name;

        // location of the waypoint in world coordinates
        public Avikom.UnityTypes.Math.Vector3D Location;

        // neightbouring waypoints; if not set they might be derived from other waypoint neighbourhood relationships
        public StringVariableSet Neighbors;

        // a 'bubble' (in meters) around a waypoint that determines when a waypoint is considered reached
        public FloatVariable Threshold;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.Waypoint proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (Location == null) { Location = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.Vector3D>(); }
            if (proto.Location != Avikom.UnityTypes.Math.Vector3D.TypeDefault)
            {
                Location.SetValue(proto.Location);
            }

            if (Neighbors == null) { Neighbors = ScriptableObject.CreateInstance<StringVariableSet>(); }
            if (proto.Neighbors.Count > 0)
            {
                Neighbors.Clear();
                foreach (var value in proto.Neighbors)
                {
                    var tmp = ScriptableObject.CreateInstance<StringVariable>();
                    tmp.SetValue(value);
                    Neighbors.Add(tmp);
                }
                Neighbors.Raise();
            }
        

            if (Threshold == null) { Threshold = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Threshold != FloatVariable.TypeDefault)
            {
                Threshold.SetValue(proto.Threshold);
            }
            Raise();
        }

        public void SetValue(Waypoint other)
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

            if (Location == null)
            {
                Location = other.Location;
            }
            else if (other.Location != null)
            {
                Location.SetValue(other.Location);
            }

            if (other.Neighbors != null)
            {
                if (Neighbors == null) { Neighbors = ScriptableObject.CreateInstance<StringVariableSet>(); }
                Neighbors.Clear();
                foreach (var elem in other.Neighbors.Items)
                {
                    Neighbors.Add(elem);
                }
                Neighbors.Raise();
            }

            if (Threshold == null)
            {
                Threshold = other.Threshold;
            }
            else if (other.Threshold != null)
            {
                Threshold.SetValue(other.Threshold);
            }
            Raise();
        }

        public Avikom.Types.Unity.Waypoint GetValue()
        {
            var proto = new Avikom.Types.Unity.Waypoint();
            proto.Name = Name?.GetValue() ?? proto.Name;
            proto.Location = Location?.GetValue() ?? proto.Location;

            foreach (var value in Neighbors.Items) { proto.Neighbors.Add(value.GetValue()); }
                        
            proto.Threshold = Threshold?.GetValue() ?? proto.Threshold;
            return proto;
        }
    }

}

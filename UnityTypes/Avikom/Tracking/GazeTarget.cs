
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Tracking
{


    [CreateAssetMenu(menuName = "Avikom/Tracking/GazeTarget")]
    public class GazeTarget : GameEvent<GazeTarget>, IGameEvent
    {
        public static Avikom.Types.Tracking.GazeTarget TypeDefault = null;
        // name or unique ID of the object hat the user looks at; might be undefined if the gaze target cannot be determined
        public StringVariable Id;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Tracking.GazeTarget proto)
        {

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }
            Raise();
        }

        public void SetValue(GazeTarget other)
        {
            if (!other) { return; }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }
            Raise();
        }

        public Avikom.Types.Tracking.GazeTarget GetValue()
        {
            var proto = new Avikom.Types.Tracking.GazeTarget();
            proto.Id = Id?.GetValue() ?? proto.Id;
            return proto;
        }
    }

}

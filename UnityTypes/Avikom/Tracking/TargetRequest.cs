
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Tracking
{

    /** This message is used to request an entities location.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tracking/TargetRequest")]
    public class TargetRequest : GameEvent<TargetRequest>, IGameEvent
    {
        public static Avikom.Types.Tracking.TargetRequest TypeDefault = null;
        // the object/entity that should be tracked
        public StringVariable Target;

        // the sleep interval between messages; should be equal or larger than time needed to process messages; a higher value reduces load on the service and on the network
        public IntVariable SleepMs;

        // the origin of relative requests
        public StringVariable Watcher;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Tracking.TargetRequest proto)
        {

            if (Target == null) { Target = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Target != StringVariable.TypeDefault)
            {
                Target.SetValue(proto.Target);
            }

            if (SleepMs == null) { SleepMs = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.SleepMs != IntVariable.TypeDefault)
            {
                SleepMs.SetValue(proto.SleepMs);
            }

            if (Watcher == null) { Watcher = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Watcher != StringVariable.TypeDefault)
            {
                Watcher.SetValue(proto.Watcher);
            }
            Raise();
        }

        public void SetValue(TargetRequest other)
        {
            if (!other) { return; }

            if (Target == null)
            {
                Target = other.Target;
            }
            else if (other.Target != null)
            {
                Target.SetValue(other.Target);
            }

            if (SleepMs == null)
            {
                SleepMs = other.SleepMs;
            }
            else if (other.SleepMs != null)
            {
                SleepMs.SetValue(other.SleepMs);
            }

            if (Watcher == null)
            {
                Watcher = other.Watcher;
            }
            else if (other.Watcher != null)
            {
                Watcher.SetValue(other.Watcher);
            }
            Raise();
        }

        public Avikom.Types.Tracking.TargetRequest GetValue()
        {
            var proto = new Avikom.Types.Tracking.TargetRequest();
            proto.Target = Target?.GetValue() ?? proto.Target;
            proto.SleepMs = SleepMs?.GetValue() ?? proto.SleepMs;
            proto.Watcher = Watcher?.GetValue() ?? proto.Watcher;
            return proto;
        }
    }

}

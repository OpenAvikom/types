
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Math
{

    /** A simple 3D float vector.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Math/Vector3D")]
    public class Vector3D : GameEvent<Vector3D>, IGameEvent
    {
        public static Avikom.Types.Math.Vector3D TypeDefault = null;
        // x-axis component
        public FloatVariable X;

        // y-axis component
        public FloatVariable Y;

        // z-axis component
        public FloatVariable Z;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Math.Vector3D proto)
        {

            if (X == null) { X = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.X != FloatVariable.TypeDefault)
            {
                X.SetValue(proto.X);
            }

            if (Y == null) { Y = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Y != FloatVariable.TypeDefault)
            {
                Y.SetValue(proto.Y);
            }

            if (Z == null) { Z = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Z != FloatVariable.TypeDefault)
            {
                Z.SetValue(proto.Z);
            }
            Raise();
        }

        public void SetValue(Vector3D other)
        {
            if (!other) { return; }

            if (X == null)
            {
                X = other.X;
            }
            else if (other.X != null)
            {
                X.SetValue(other.X);
            }

            if (Y == null)
            {
                Y = other.Y;
            }
            else if (other.Y != null)
            {
                Y.SetValue(other.Y);
            }

            if (Z == null)
            {
                Z = other.Z;
            }
            else if (other.Z != null)
            {
                Z.SetValue(other.Z);
            }
            Raise();
        }

        public Avikom.Types.Math.Vector3D GetValue()
        {
            var proto = new Avikom.Types.Math.Vector3D();
            proto.X = X?.GetValue() ?? proto.X;
            proto.Y = Y?.GetValue() ?? proto.Y;
            proto.Z = Z?.GetValue() ?? proto.Z;
            return proto;
        }
    }

}

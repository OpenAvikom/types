
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** This message describes a 3D world pose of an object/entity.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/Transpose")]
    public class Transpose : GameEvent<Transpose>, IGameEvent
    {
        public static Avikom.Types.Unity.Transpose TypeDefault = null;
        // position in world units (meters) of the entity
        public Avikom.UnityTypes.Math.Vector3D Position;

        // rotation in euler angles (degrees)
        public Avikom.UnityTypes.Math.Vector3D Rotation;

        // three dimensional scaling factor
        public Avikom.UnityTypes.Math.Vector3D Scale;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.Transpose proto)
        {

            if (Position == null) { Position = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.Vector3D>(); }
            if (proto.Position != Avikom.UnityTypes.Math.Vector3D.TypeDefault)
            {
                Position.SetValue(proto.Position);
            }

            if (Rotation == null) { Rotation = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.Vector3D>(); }
            if (proto.Rotation != Avikom.UnityTypes.Math.Vector3D.TypeDefault)
            {
                Rotation.SetValue(proto.Rotation);
            }

            if (Scale == null) { Scale = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.Vector3D>(); }
            if (proto.Scale != Avikom.UnityTypes.Math.Vector3D.TypeDefault)
            {
                Scale.SetValue(proto.Scale);
            }
            Raise();
        }

        public void SetValue(Transpose other)
        {
            if (!other) { return; }

            if (Position == null)
            {
                Position = other.Position;
            }
            else if (other.Position != null)
            {
                Position.SetValue(other.Position);
            }

            if (Rotation == null)
            {
                Rotation = other.Rotation;
            }
            else if (other.Rotation != null)
            {
                Rotation.SetValue(other.Rotation);
            }

            if (Scale == null)
            {
                Scale = other.Scale;
            }
            else if (other.Scale != null)
            {
                Scale.SetValue(other.Scale);
            }
            Raise();
        }

        public Avikom.Types.Unity.Transpose GetValue()
        {
            var proto = new Avikom.Types.Unity.Transpose();
            proto.Position = Position?.GetValue() ?? proto.Position;
            proto.Rotation = Rotation?.GetValue() ?? proto.Rotation;
            proto.Scale = Scale?.GetValue() ?? proto.Scale;
            return proto;
        }
    }

}

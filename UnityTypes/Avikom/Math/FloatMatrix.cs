
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Math
{

    /** An list of `FloatArrays` meant to store matrices.
    @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Math/FloatMatrix")]
    public class FloatMatrix : GameEvent<FloatMatrix>, IGameEvent
    {
        public static Avikom.Types.Math.FloatMatrix TypeDefault = null;
        // list of `FloatArrays`
        public Avikom.UnityTypes.Math.FloatArray Rows;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Math.FloatMatrix proto)
        {

            if (Rows == null) { Rows = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.FloatArray>(); }
            if (proto.Rows != Avikom.UnityTypes.Math.FloatArray.TypeDefault)
            {
                Rows.SetValue(proto.Rows);
            }
            Raise();
        }

        public void SetValue(FloatMatrix other)
        {
            if (!other) { return; }

            if (Rows == null)
            {
                Rows = other.Rows;
            }
            else if (other.Rows != null)
            {
                Rows.SetValue(other.Rows);
            }
            Raise();
        }

        public Avikom.Types.Math.FloatMatrix GetValue()
        {
            var proto = new Avikom.Types.Math.FloatMatrix();
            proto.Rows = Rows?.GetValue() ?? proto.Rows;
            return proto;
        }
    }

}

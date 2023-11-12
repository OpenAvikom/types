
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
        public Avikom.UnityTypes.Math.FloatArraySet Rows;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Math.FloatMatrix proto)
        {

            if (Rows == null) { Rows = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.FloatArraySet>(); }
            if (proto.Rows.Count > 0)
            {
                Rows.Clear();
                foreach (var value in proto.Rows)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.FloatArray>();
                    tmp.SetValue(value);
                    Rows.Add(tmp);
                }
                Rows.Raise();
            }
        
            Raise();
        }

        public void SetValue(FloatMatrix other)
        {
            if (!other) { return; }

            if (other.Rows != null)
            {
                if (Rows == null) { Rows = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.FloatArraySet>(); }
                Rows.Clear();
                foreach (var elem in other.Rows.Items)
                {
                    Rows.Add(elem);
                }
                Rows.Raise();
            }
            Raise();
        }

        public Avikom.Types.Math.FloatMatrix GetValue()
        {
            var proto = new Avikom.Types.Math.FloatMatrix();

            foreach (var value in Rows.Items) { proto.Rows.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

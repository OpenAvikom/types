
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Math
{

    /** A simple list of floats. Might be used in a variety of context. E.g. as a row to a matrix.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Math/FloatArray")]
    public class FloatArray : GameEvent<FloatArray>, IGameEvent
    {
        public static Avikom.Types.Math.FloatArray TypeDefault = null;
        // list of floating point numbers
        public FloatVariable Items;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Math.FloatArray proto)
        {

            if (Items == null) { Items = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Items != FloatVariable.TypeDefault)
            {
                Items.SetValue(proto.Items);
            }
            Raise();
        }

        public void SetValue(FloatArray other)
        {
            if (!other) { return; }

            if (Items == null)
            {
                Items = other.Items;
            }
            else if (other.Items != null)
            {
                Items.SetValue(other.Items);
            }
            Raise();
        }

        public Avikom.Types.Math.FloatArray GetValue()
        {
            var proto = new Avikom.Types.Math.FloatArray();
            proto.Items = Items?.GetValue() ?? proto.Items;
            return proto;
        }
    }

}

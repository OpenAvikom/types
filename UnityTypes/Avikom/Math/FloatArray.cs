
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
        public FloatVariableSet Items;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Math.FloatArray proto)
        {

            if (Items == null) { Items = ScriptableObject.CreateInstance<FloatVariableSet>(); }
            if (proto.Items.Count > 0)
            {
                Items.Clear();
                foreach (var value in proto.Items)
                {
                    var tmp = ScriptableObject.CreateInstance<FloatVariable>();
                    tmp.SetValue(value);
                    Items.Add(tmp);
                }
                Items.Raise();
            }
        
            Raise();
        }

        public void SetValue(FloatArray other)
        {
            if (!other) { return; }

            if (other.Items != null)
            {
                if (Items == null) { Items = ScriptableObject.CreateInstance<FloatVariableSet>(); }
                Items.Clear();
                foreach (var elem in other.Items.Items)
                {
                    Items.Add(elem);
                }
                Items.Raise();
            }
            Raise();
        }

        public Avikom.Types.Math.FloatArray GetValue()
        {
            var proto = new Avikom.Types.Math.FloatArray();

            foreach (var value in Items.Items) { proto.Items.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

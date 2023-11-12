
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Glasses
{

    /** A list of all calibration objects/space pin names.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/SpacePinNames")]
    public class SpacePinNames : GameEvent<SpacePinNames>, IGameEvent
    {
        public static Avikom.Types.Glasses.SpacePinNames TypeDefault = null;
        // list of names
        public StringVariableSet Names;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Glasses.SpacePinNames proto)
        {

            if (Names == null) { Names = ScriptableObject.CreateInstance<StringVariableSet>(); }
            if (proto.Names.Count > 0)
            {
                Names.Clear();
                foreach (var value in proto.Names)
                {
                    var tmp = ScriptableObject.CreateInstance<StringVariable>();
                    tmp.SetValue(value);
                    Names.Add(tmp);
                }
                Names.Raise();
            }
        
            Raise();
        }

        public void SetValue(SpacePinNames other)
        {
            if (!other) { return; }

            if (other.Names != null)
            {
                if (Names == null) { Names = ScriptableObject.CreateInstance<StringVariableSet>(); }
                Names.Clear();
                foreach (var elem in other.Names.Items)
                {
                    Names.Add(elem);
                }
                Names.Raise();
            }
            Raise();
        }

        public Avikom.Types.Glasses.SpacePinNames GetValue()
        {
            var proto = new Avikom.Types.Glasses.SpacePinNames();

            foreach (var value in Names.Items) { proto.Names.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}


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
        public StringVariable Names;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Glasses.SpacePinNames proto)
        {

            if (Names == null) { Names = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Names != StringVariable.TypeDefault)
            {
                Names.SetValue(proto.Names);
            }
            Raise();
        }

        public void SetValue(SpacePinNames other)
        {
            if (!other) { return; }

            if (Names == null)
            {
                Names = other.Names;
            }
            else if (other.Names != null)
            {
                Names.SetValue(other.Names);
            }
            Raise();
        }

        public Avikom.Types.Glasses.SpacePinNames GetValue()
        {
            var proto = new Avikom.Types.Glasses.SpacePinNames();
            proto.Names = Names?.GetValue() ?? proto.Names;
            return proto;
        }
    }

}

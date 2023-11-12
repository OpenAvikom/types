
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A query passed to RasaService
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/RasaQuery")]
    public class RasaQuery : GameEvent<RasaQuery>, IGameEvent
    {
        public static Avikom.Types.Headset.RasaQuery TypeDefault = null;
        // the id of the user for which information shall be queried
        public UnsignedLongVariable UserId;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.RasaQuery proto)
        {

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.UserId != UnsignedLongVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }
            Raise();
        }

        public void SetValue(RasaQuery other)
        {
            if (!other) { return; }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }
            Raise();
        }

        public Avikom.Types.Headset.RasaQuery GetValue()
        {
            var proto = new Avikom.Types.Headset.RasaQuery();
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            return proto;
        }
    }

}


using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A message including the name of the peer being queried
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/PeerStorageQuery")]
    public class PeerStorageQuery : GameEvent<PeerStorageQuery>, IGameEvent
    {
        public static Avikom.Types.Generic.PeerStorageQuery TypeDefault = null;
        // unique name of a peer
        public StringVariable Name;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.PeerStorageQuery proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }
            Raise();
        }

        public void SetValue(PeerStorageQuery other)
        {
            if (!other) { return; }

            if (Name == null)
            {
                Name = other.Name;
            }
            else if (other.Name != null)
            {
                Name.SetValue(other.Name);
            }
            Raise();
        }

        public Avikom.Types.Generic.PeerStorageQuery GetValue()
        {
            var proto = new Avikom.Types.Generic.PeerStorageQuery();
            proto.Name = Name?.GetValue() ?? proto.Name;
            return proto;
        }
    }

}


using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A list of peers that is commonly associated with steps and or runtime task steps.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/PeerList")]
    public class PeerList : GameEvent<PeerList>, IGameEvent
    {
        public static Avikom.Types.Generic.PeerList TypeDefault = null;
        // A list of peers.
        public Avikom.UnityTypes.Generic.Peer Peers;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.PeerList proto)
        {

            if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>(); }
            if (proto.Peers != Avikom.UnityTypes.Generic.Peer.TypeDefault)
            {
                Peers.SetValue(proto.Peers);
            }
            Raise();
        }

        public void SetValue(PeerList other)
        {
            if (!other) { return; }

            if (Peers == null)
            {
                Peers = other.Peers;
            }
            else if (other.Peers != null)
            {
                Peers.SetValue(other.Peers);
            }
            Raise();
        }

        public Avikom.Types.Generic.PeerList GetValue()
        {
            var proto = new Avikom.Types.Generic.PeerList();
            proto.Peers = Peers?.GetValue() ?? proto.Peers;
            return proto;
        }
    }

}

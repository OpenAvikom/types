
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
        public Avikom.UnityTypes.Generic.PeerSet Peers;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.PeerList proto)
        {

            if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.PeerSet>(); }
            if (proto.Peers.Count > 0)
            {
                Peers.Clear();
                foreach (var value in proto.Peers)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>();
                    tmp.SetValue(value);
                    Peers.Add(tmp);
                }
                Peers.Raise();
            }
        
            Raise();
        }

        public void SetValue(PeerList other)
        {
            if (!other) { return; }

            if (other.Peers != null)
            {
                if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.PeerSet>(); }
                Peers.Clear();
                foreach (var elem in other.Peers.Items)
                {
                    Peers.Add(elem);
                }
                Peers.Raise();
            }
            Raise();
        }

        public Avikom.Types.Generic.PeerList GetValue()
        {
            var proto = new Avikom.Types.Generic.PeerList();

            foreach (var value in Peers.Items) { proto.Peers.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

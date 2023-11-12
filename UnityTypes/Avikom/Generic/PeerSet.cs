
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A representation of a service system to connect to or to exchange data with.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/PeerSet")]
    public class PeerSet : Avikom.UnityAssets.Sets.RuntimeSet<Peer> { }

}

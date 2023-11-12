
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A message including the name of the peer being queried
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/PeerStorageQuerySet")]
    public class PeerStorageQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<PeerStorageQuery> { }

}

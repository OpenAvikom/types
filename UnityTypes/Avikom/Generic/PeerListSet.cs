
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A list of peers that is commonly associated with steps and or runtime task steps.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/PeerListSet")]
    public class PeerListSet : Avikom.UnityAssets.Sets.RuntimeSet<PeerList> { }

}

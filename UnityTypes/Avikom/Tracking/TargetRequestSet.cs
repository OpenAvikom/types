
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Tracking
{

    /** This message is used to request an entities location.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tracking/TargetRequestSet")]
    public class TargetRequestSet : Avikom.UnityAssets.Sets.RuntimeSet<TargetRequest> { }

}

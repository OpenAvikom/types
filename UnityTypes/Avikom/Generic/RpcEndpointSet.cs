
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** Indicates the RPC endpoints a peer implements/provides.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/RpcEndpointSet")]
    public class RpcEndpointSet : Avikom.UnityAssets.Sets.RuntimeSet<RpcEndpoint> { }

}

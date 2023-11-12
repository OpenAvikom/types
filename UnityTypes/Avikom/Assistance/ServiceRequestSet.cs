
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A request passed to `ServiceProviderService`.
     @author Alexander McService Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ServiceRequestSet")]
    public class ServiceRequestSet : Avikom.UnityAssets.Sets.RuntimeSet<ServiceRequest> { }

}

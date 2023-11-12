
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A message that combines peer topics and related service configurations meant for TaskStep definitions.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ServiceConfigurationSet")]
    public class ServiceConfigurationSet : Avikom.UnityAssets.Sets.RuntimeSet<ServiceConfiguration> { }

}

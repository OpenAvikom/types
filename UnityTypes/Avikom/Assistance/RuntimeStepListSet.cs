
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A list of `RuntimeTaskSteps`. It also contains a list of `Peers` which can be used to conduct the passed steps.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepListSet")]
    public class RuntimeStepListSet : Avikom.UnityAssets.Sets.RuntimeSet<RuntimeStepList> { }

}

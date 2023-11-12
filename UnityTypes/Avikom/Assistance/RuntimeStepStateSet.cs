
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A step state resembled an `IssueState` in many cases but is more detailed.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepStateSet")]
    public class RuntimeStepStateSet : Avikom.UnityAssets.Sets.RuntimeSet<RuntimeStepState> { }

}

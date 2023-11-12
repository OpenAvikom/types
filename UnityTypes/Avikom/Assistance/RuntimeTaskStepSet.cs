
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** Adds runtime-specific (temporal) data to a (static) TaskStep
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeTaskStepSet")]
    public class RuntimeTaskStepSet : Avikom.UnityAssets.Sets.RuntimeSet<RuntimeTaskStep> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A message that combines the `RuntimeTaskStep` id and the state update.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepStateChangeSet")]
    public class RuntimeStepStateChangeSet : Avikom.UnityAssets.Sets.RuntimeSet<RuntimeStepStateChange> { }

}

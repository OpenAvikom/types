
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** An event that should be processed by the BPM engine (Camunda) and/or AVIKOM services.
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskEventSet")]
    public class TaskEventSet : Avikom.UnityAssets.Sets.RuntimeSet<TaskEvent> { }

}

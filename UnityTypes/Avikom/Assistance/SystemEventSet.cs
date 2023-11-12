
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** An enum representing an event hat has been triggered by some (parallel) activity of the system.
     Event handling should be done by a SessionService and should be converted into a string beforehand.
     Note that custom and task-specific events are defined as strings right away. This enum shall only be used for 
     reoccuring task-independent events.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SystemEventSet")]
    public class SystemEventSet : Avikom.UnityAssets.Sets.RuntimeSet<SystemEvent> { }

}

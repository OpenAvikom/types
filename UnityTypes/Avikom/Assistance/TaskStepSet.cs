
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a task step. A step describes an individual operation of a certain stereotype that 
     should be compatible with the 'Basic Action Concept' (BAC) of SDA-M.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStepSet")]
    public class TaskStepSet : Avikom.UnityAssets.Sets.RuntimeSet<TaskStep> { }

}

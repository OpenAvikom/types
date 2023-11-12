
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a specific Task which can include several task steps.
     A task may be conducted in several locations (scenes). 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskSet")]
    public class TaskSet : Avikom.UnityAssets.Sets.RuntimeSet<Task> { }

}

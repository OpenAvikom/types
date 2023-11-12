
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** A message to query a task configuration by `task_name`.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/TaskConfigQuerySet")]
    public class TaskConfigQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<TaskConfigQuery> { }

}

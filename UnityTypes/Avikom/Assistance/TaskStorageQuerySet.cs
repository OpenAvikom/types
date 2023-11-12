
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A query to retrieve a scene, task or task step via its name.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStorageQuerySet")]
    public class TaskStorageQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<TaskStorageQuery> { }

}

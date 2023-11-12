
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** This message describes a task config and contains context-specific objects.
     All assets should have a parent that represents their location within a scene.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/TaskConfigSet")]
    public class TaskConfigSet : Avikom.UnityAssets.Sets.RuntimeSet<TaskConfig> { }

}

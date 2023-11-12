
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** Describes the location/context of a task. This might be an office or a lab.
     The `tasks` field should only contain tasks that can be intialized without further information.
     For instance, when a task requires to be prepened by another task, it should be mentioned here.
     Thus, an `Issue` might contain a task that is not mentioned in `Session.tasks`.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SceneSet")]
    public class SceneSet : Avikom.UnityAssets.Sets.RuntimeSet<Scene> { }

}

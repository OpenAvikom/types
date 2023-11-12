
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This messages classifies the assistance mechanism needed for a `TaskStep`.
     Paramaters may contain variable names in `{curly brackets}`.
     These should be resolved during runtime with the session's variable content.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStereotypeSet")]
    public class TaskStereotypeSet : Avikom.UnityAssets.Sets.RuntimeSet<TaskStereotype> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** An message that contains informations about (postponed) tasks and their state.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueSet")]
    public class IssueSet : Avikom.UnityAssets.Sets.RuntimeSet<Issue> { }

}

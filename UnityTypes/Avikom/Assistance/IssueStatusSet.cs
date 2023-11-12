
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** The status of an issue. Can be used to find unresolved tasks and filter issue lists.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueStatusSet")]
    public class IssueStatusSet : Avikom.UnityAssets.Sets.RuntimeSet<IssueStatus> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** Query an issue from the storage or the session manager. Fields can be combined and intersections will be returned.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueQuerySet")]
    public class IssueQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<IssueQuery> { }

}

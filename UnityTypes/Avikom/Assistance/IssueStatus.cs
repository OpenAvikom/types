
using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityTypes.Assistance
{

    /** The status of an issue. Can be used to find unresolved tasks and filter issue lists.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueStatus")]
    public class IssueStatus : EnumVariable<Avikom.Types.Assistance.IssueStatus> { }

}

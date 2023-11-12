
using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityTypes.Assistance
{

    /** A step state resembled an `IssueState` in many cases but is more detailed.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/RuntimeStepState")]
    public class RuntimeStepState : EnumVariable<Avikom.Types.Assistance.RuntimeStepState> { }

}

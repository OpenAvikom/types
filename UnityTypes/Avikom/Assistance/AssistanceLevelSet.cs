
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This enum describes the assistance level required by a user or assigned to an instruction.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/AssistanceLevelSet")]
    public class AssistanceLevelSet : Avikom.UnityAssets.Sets.RuntimeSet<AssistanceLevel> { }

}

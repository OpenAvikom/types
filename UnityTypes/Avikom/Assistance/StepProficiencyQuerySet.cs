
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A query to retrieve `StepProficiencies` for task steps or `SplitProcedureResults` for taks
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/StepProficiencyQuerySet")]
    public class StepProficiencyQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<StepProficiencyQuery> { }

}

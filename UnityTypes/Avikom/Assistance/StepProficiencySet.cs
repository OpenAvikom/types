
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A message to describe the step proficiency of a user. 
     This includes the currently required assistance level but also parameters to determine when or if AVIKOM will attempt to reduce the assistance level.
     @author: Alexander Neumann <alneuma@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/StepProficiencySet")]
    public class StepProficiencySet : Avikom.UnityAssets.Sets.RuntimeSet<StepProficiency> { }

}

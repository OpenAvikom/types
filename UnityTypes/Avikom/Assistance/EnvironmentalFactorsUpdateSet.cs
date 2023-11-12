
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A message to update current environmental factors such as brightness and/or volume for a user session or a scene.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/EnvironmentalFactorsUpdateSet")]
    public class EnvironmentalFactorsUpdateSet : Avikom.UnityAssets.Sets.RuntimeSet<EnvironmentalFactorsUpdate> { }

}

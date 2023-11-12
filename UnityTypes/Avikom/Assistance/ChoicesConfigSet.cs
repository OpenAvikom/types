
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a choice a peer/user can make.
     It contains state information for each individual choice that can be made
     to enable multiple selections in a looped interaction.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ChoicesConfigSet")]
    public class ChoicesConfigSet : Avikom.UnityAssets.Sets.RuntimeSet<ChoicesConfig> { }

}

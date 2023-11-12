
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** This message represents a choice a user can select. It is commonly part of a selection of choices 
     in a ChoiceConfig.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ChoiceItemSet")]
    public class ChoiceItemSet : Avikom.UnityAssets.Sets.RuntimeSet<ChoiceItem> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Glasses
{

    /** This message describes a user interaction with a virtual or real-world artifact.
     The kind and target of an interaction is communicated.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/InteractionEventSet")]
    public class InteractionEventSet : Avikom.UnityAssets.Sets.RuntimeSet<InteractionEvent> { }

}

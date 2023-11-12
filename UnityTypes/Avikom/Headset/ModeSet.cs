
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** Defines the mode that should be activated for the auditory peer. The mode changes the auditory input and output 
     behaviour of the auditory peer.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/ModeSet")]
    public class ModeSet : Avikom.UnityAssets.Sets.RuntimeSet<Mode> { }

}
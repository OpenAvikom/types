
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** This enum describes common functional sounds that can be played back on an auditory peer
     to provide feedback to a user.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/FunctionalSoundSet")]
    public class FunctionalSoundSet : Avikom.UnityAssets.Sets.RuntimeSet<FunctionalSound> { }

}

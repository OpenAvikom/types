
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** A FunctionalSound request that either includes a standardized functional sound or the name of 
     an audio file to be played. The audio file has to be available in the web-client data path "data/Default/Sounds".
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/FunctionalSoundRequestSet")]
    public class FunctionalSoundRequestSet : Avikom.UnityAssets.Sets.RuntimeSet<FunctionalSoundRequest> { }

}

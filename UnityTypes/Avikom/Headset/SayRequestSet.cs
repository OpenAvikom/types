
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** A request that either includes a standardized utterance or custom output to be played back via TTS. 
     The output is queued with other speech output.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/SayRequestSet")]
    public class SayRequestSet : Avikom.UnityAssets.Sets.RuntimeSet<SayRequest> { }

}

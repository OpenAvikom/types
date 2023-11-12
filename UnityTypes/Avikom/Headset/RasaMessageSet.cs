
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Headset
{

    /** A RasaMessage provides the intents and slots recognized by rasa for a specific user.
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/RasaMessageSet")]
    public class RasaMessageSet : Avikom.UnityAssets.Sets.RuntimeSet<RasaMessage> { }

}

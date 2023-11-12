
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** This message is used to transfer associated information (i.e. slots extracted by rasa). 
     @author Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/KeyValuePairSet")]
    public class KeyValuePairSet : Avikom.UnityAssets.Sets.RuntimeSet<KeyValuePair> { }

}

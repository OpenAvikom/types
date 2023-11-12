
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A more elaborate profile of a user including additional data (i.e. "Stammdaten").
     User Attribution is mandatory, all other fields are optional
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/UserProfileSet")]
    public class UserProfileSet : Avikom.UnityAssets.Sets.RuntimeSet<UserProfile> { }

}

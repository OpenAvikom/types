
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Generic
{

    /** A message that contains data about a user that is essential for system operation.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/UserSet")]
    public class UserSet : Avikom.UnityAssets.Sets.RuntimeSet<User> { }

}

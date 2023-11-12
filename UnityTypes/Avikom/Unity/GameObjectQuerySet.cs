
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** A query message to retrieve information about an object in the scene.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/GameObjectQuerySet")]
    public class GameObjectQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<GameObjectQuery> { }

}

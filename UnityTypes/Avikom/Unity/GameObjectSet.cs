
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** This message describes a (virtual) object in the current scene.
     Properties have been chosen to allo Unity-based peers to create instances from such a message.
     However, this message might also be used in contexts where rendering is not necessary.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/GameObjectSet")]
    public class GameObjectSet : Avikom.UnityAssets.Sets.RuntimeSet<GameObject> { }

}

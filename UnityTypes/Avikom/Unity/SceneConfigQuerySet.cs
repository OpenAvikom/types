
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** A message to query a scene configuration by `scene_name`.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/SceneConfigQuerySet")]
    public class SceneConfigQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<SceneConfigQuery> { }

}

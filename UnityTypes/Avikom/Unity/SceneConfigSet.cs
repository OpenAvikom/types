
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** This message describes a scene config and contains location-bound parameters.
     It should also provide semantic anchors for task-specific configurations to be attached. 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/SceneConfigSet")]
    public class SceneConfigSet : Avikom.UnityAssets.Sets.RuntimeSet<SceneConfig> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** Provides an interface to request AssetBundles from a server. 
    @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundleSet")]
    public class AssetBundleSet : Avikom.UnityAssets.Sets.RuntimeSet<AssetBundle> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** A message to request asset bundles from a server.
    @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundleQuerySet")]
    public class AssetBundleQuerySet : Avikom.UnityAssets.Sets.RuntimeSet<AssetBundleQuery> { }

}

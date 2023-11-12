
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** A message header to send Unity asset bundles in chunks.
     Should be available in every initial message to an asset bunde receiver.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundleInfoSet")]
    public class AssetBundleInfoSet : Avikom.UnityAssets.Sets.RuntimeSet<AssetBundleInfo> { }

}

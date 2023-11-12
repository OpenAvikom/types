
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Vision
{

    /** This message is a header for image data transfer in chunks.
     It should always be set in the first `Image` message send to an image receiver.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/ImageInfoSet")]
    public class ImageInfoSet : Avikom.UnityAssets.Sets.RuntimeSet<ImageInfo> { }

}

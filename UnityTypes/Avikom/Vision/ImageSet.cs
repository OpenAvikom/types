
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Vision
{

    /** This message represents a (chunk of an) image. It may contain an `ImageInfo` header or a chunk of data of an image. */
    [CreateAssetMenu(menuName = "Avikom/Vision/ImageSet")]
    public class ImageSet : Avikom.UnityAssets.Sets.RuntimeSet<Image> { }

}

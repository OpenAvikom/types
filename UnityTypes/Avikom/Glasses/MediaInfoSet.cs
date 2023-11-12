
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Glasses
{

    /** This message describes a media file, it's name (or file path), its content type (e.g. video, audio, image) and the current playback time if applicable.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/MediaInfoSet")]
    public class MediaInfoSet : Avikom.UnityAssets.Sets.RuntimeSet<MediaInfo> { }

}

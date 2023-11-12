
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Vision
{

    /** This message represents the camera state mostly associated with Unity as only one service may use the system's camera at a time.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/CameraStateSet")]
    public class CameraStateSet : Avikom.UnityAssets.Sets.RuntimeSet<CameraState> { }

}

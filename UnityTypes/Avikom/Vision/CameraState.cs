
using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityTypes.Vision
{

    /** This message represents the camera state mostly associated with Unity as only one service may use the system's camera at a time.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/CameraState")]
    public class CameraState : EnumVariable<Avikom.Types.Vision.CameraState> { }

}

using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityTypes.Vision
{

    /** This message represents the EVENT or REQUEST to acquire the camera.
     Whether the camera can be acquired depends on its current state. 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/CameraTrigger")]
    public class CameraTrigger : EnumVariable<Avikom.Types.Vision.CameraTrigger> { }

}

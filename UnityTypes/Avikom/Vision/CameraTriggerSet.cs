
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Vision
{

    /** This message represents the EVENT or REQUEST to acquire the camera.
     Whether the camera can be acquired depends on its current state. 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Vision/CameraTriggerSet")]
    public class CameraTriggerSet : Avikom.UnityAssets.Sets.RuntimeSet<CameraTrigger> { }

}

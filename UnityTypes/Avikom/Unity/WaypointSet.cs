
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Unity
{

    /** This describes a point in space and its conceptual neighbours.
     Waypoints are used to savely guide users from one location to another.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/WaypointSet")]
    public class WaypointSet : Avikom.UnityAssets.Sets.RuntimeSet<Waypoint> { }

}

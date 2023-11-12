
using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** An event triggered by a peer to be escalated to the BPM engine (Camunda)
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SessionEventSet")]
    public class SessionEventSet : Avikom.UnityAssets.Sets.RuntimeSet<SessionEvent> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Assistance
{

    /** A (serializable) version of a session.
    Data should only be stored in json format if the represented data cannot be generalized.
    Note that sessions might contain temporal data that cannot be stored because of their short-times lifespan or due to serializiation limitations.
    For these cases, separate setup and tear down strategies should be considered.
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SessionSet")]
    public class SessionSet : Avikom.UnityAssets.Sets.RuntimeSet<Session> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Tunnel
{

    /** A message to be sent from a server to a tunneled client.
     Clients need to resolve the (local) method name and assign the correct message IDs to responses
     sent back to the server.
     Note that method names may differ depending on the client's language.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tunnel/ServerToClientSet")]
    public class ServerToClientSet : Avikom.UnityAssets.Sets.RuntimeSet<ServerToClient> { }

}


using UnityEngine;
using Avikom.UnityAssets.Sets;



namespace Avikom.UnityTypes.Tunnel
{

    /** A message to be sent from a tunneled client to the server that (will) receive messages
     meant for this client. The first message should contain peer information and ByteString
     responses afterwards.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tunnel/ClientToServerSet")]
    public class ClientToServerSet : Avikom.UnityAssets.Sets.RuntimeSet<ClientToServer> { }

}

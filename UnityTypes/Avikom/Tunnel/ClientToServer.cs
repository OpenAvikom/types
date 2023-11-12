
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Tunnel
{

    /** A message to be sent from a tunneled client to the server that (will) receive messages
     meant for this client. The first message should contain peer information and ByteString
     responses afterwards.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tunnel/ClientToServer")]
    public class ClientToServer : GameEvent<ClientToServer>, IGameEvent
    {
        public static Avikom.Types.Tunnel.ClientToServer TypeDefault = null;
        // A response to a RPC processed by the client
        public ByteArrayVariable Response;

        // The ID of the call related to the response
        public UnsignedLongVariable MessageId;

        // Client information sent as the first message to the server
        public Avikom.UnityTypes.Generic.Peer Peer;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Tunnel.ClientToServer proto)
        {

            if (Response == null) { Response = ScriptableObject.CreateInstance<ByteArrayVariable>(); }
            if (!proto.Response.IsEmpty)
            {
                Response.SetValue(proto.Response.ToByteArray());
            }

            if (MessageId == null) { MessageId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.MessageId != UnsignedLongVariable.TypeDefault)
            {
                MessageId.SetValue(proto.MessageId);
            }

            if (Peer == null) { Peer = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>(); }
            if (proto.Peer != Avikom.UnityTypes.Generic.Peer.TypeDefault)
            {
                Peer.SetValue(proto.Peer);
            }
            Raise();
        }

        public void SetValue(ClientToServer other)
        {
            if (!other) { return; }

            if (Response == null)
            {
                Response = other.Response;
            }
            else if (other.Response != null)
            {
                Response.SetValue(other.Response);
            }

            if (MessageId == null)
            {
                MessageId = other.MessageId;
            }
            else if (other.MessageId != null)
            {
                MessageId.SetValue(other.MessageId);
            }

            if (Peer == null)
            {
                Peer = other.Peer;
            }
            else if (other.Peer != null)
            {
                Peer.SetValue(other.Peer);
            }
            Raise();
        }

        public Avikom.Types.Tunnel.ClientToServer GetValue()
        {
            var proto = new Avikom.Types.Tunnel.ClientToServer();
            proto.Response = (Response != null) ? ByteString.CopyFrom(Response.GetValue(), 0, Response.GetValue().Length) : proto.Response;
            proto.MessageId = MessageId?.GetValue() ?? proto.MessageId;
            proto.Peer = Peer?.GetValue() ?? proto.Peer;
            return proto;
        }
    }

}


using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Tunnel
{

    /** A message to be sent from a server to a tunneled client.
     Clients need to resolve the (local) method name and assign the correct message IDs to responses
     sent back to the server.
     Note that method names may differ depending on the client's language.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Tunnel/ServerToClient")]
    public class ServerToClient : GameEvent<ServerToClient>, IGameEvent
    {
        public static Avikom.Types.Tunnel.ServerToClient TypeDefault = null;
        // Method name in CapitalCase since this is the default proto style
        public StringVariable Method;

        // A message as a byte string; needs to be parsed and forwarded to the local gRPC server
        public ByteArrayVariable Request;

        // An ID associated with the request; A response must contain the correct ID!
        public UnsignedLongVariable MessageId;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Tunnel.ServerToClient proto)
        {

            if (Method == null) { Method = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Method != StringVariable.TypeDefault)
            {
                Method.SetValue(proto.Method);
            }

            if (Request == null) { Request = ScriptableObject.CreateInstance<ByteArrayVariable>(); }
            if (!proto.Request.IsEmpty)
            {
                Request.SetValue(proto.Request.ToByteArray());
            }

            if (MessageId == null) { MessageId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.MessageId != UnsignedLongVariable.TypeDefault)
            {
                MessageId.SetValue(proto.MessageId);
            }
            Raise();
        }

        public void SetValue(ServerToClient other)
        {
            if (!other) { return; }

            if (Method == null)
            {
                Method = other.Method;
            }
            else if (other.Method != null)
            {
                Method.SetValue(other.Method);
            }

            if (Request == null)
            {
                Request = other.Request;
            }
            else if (other.Request != null)
            {
                Request.SetValue(other.Request);
            }

            if (MessageId == null)
            {
                MessageId = other.MessageId;
            }
            else if (other.MessageId != null)
            {
                MessageId.SetValue(other.MessageId);
            }
            Raise();
        }

        public Avikom.Types.Tunnel.ServerToClient GetValue()
        {
            var proto = new Avikom.Types.Tunnel.ServerToClient();
            proto.Method = Method?.GetValue() ?? proto.Method;
            proto.Request = (Request != null) ? ByteString.CopyFrom(Request.GetValue(), 0, Request.GetValue().Length) : proto.Request;
            proto.MessageId = MessageId?.GetValue() ?? proto.MessageId;
            return proto;
        }
    }

}

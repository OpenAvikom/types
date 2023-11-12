
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** An event triggered by a peer to be escalated to the BPM engine (Camunda)
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SessionEvent")]
    public class SessionEvent : GameEvent<SessionEvent>, IGameEvent
    {
        public static Avikom.Types.Assistance.SessionEvent TypeDefault = null;
        // session of the event
        public StringVariable SessionId;

        // the unique event name
        public StringVariable EventName;

        // who triggered the event
        public Avikom.UnityTypes.Generic.Peer Sender;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SessionEvent proto)
        {

            if (SessionId == null) { SessionId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SessionId != StringVariable.TypeDefault)
            {
                SessionId.SetValue(proto.SessionId);
            }

            if (EventName == null) { EventName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.EventName != StringVariable.TypeDefault)
            {
                EventName.SetValue(proto.EventName);
            }

            if (Sender == null) { Sender = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>(); }
            if (proto.Sender != Avikom.UnityTypes.Generic.Peer.TypeDefault)
            {
                Sender.SetValue(proto.Sender);
            }
            Raise();
        }

        public void SetValue(SessionEvent other)
        {
            if (!other) { return; }

            if (SessionId == null)
            {
                SessionId = other.SessionId;
            }
            else if (other.SessionId != null)
            {
                SessionId.SetValue(other.SessionId);
            }

            if (EventName == null)
            {
                EventName = other.EventName;
            }
            else if (other.EventName != null)
            {
                EventName.SetValue(other.EventName);
            }

            if (Sender == null)
            {
                Sender = other.Sender;
            }
            else if (other.Sender != null)
            {
                Sender.SetValue(other.Sender);
            }
            Raise();
        }

        public Avikom.Types.Assistance.SessionEvent GetValue()
        {
            var proto = new Avikom.Types.Assistance.SessionEvent();
            proto.SessionId = SessionId?.GetValue() ?? proto.SessionId;
            proto.EventName = EventName?.GetValue() ?? proto.EventName;
            proto.Sender = Sender?.GetValue() ?? proto.Sender;
            return proto;
        }
    }

}

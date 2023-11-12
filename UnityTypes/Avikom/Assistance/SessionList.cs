
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of sessions with just one field.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SessionList")]
    public class SessionList : GameEvent<SessionList>, IGameEvent
    {
        public static Avikom.Types.Assistance.SessionList TypeDefault = null;
        // session list
        public Avikom.UnityTypes.Assistance.Session Sessions;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SessionList proto)
        {

            if (Sessions == null) { Sessions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Session>(); }
            if (proto.Sessions != Avikom.UnityTypes.Assistance.Session.TypeDefault)
            {
                Sessions.SetValue(proto.Sessions);
            }
            Raise();
        }

        public void SetValue(SessionList other)
        {
            if (!other) { return; }

            if (Sessions == null)
            {
                Sessions = other.Sessions;
            }
            else if (other.Sessions != null)
            {
                Sessions.SetValue(other.Sessions);
            }
            Raise();
        }

        public Avikom.Types.Assistance.SessionList GetValue()
        {
            var proto = new Avikom.Types.Assistance.SessionList();
            proto.Sessions = Sessions?.GetValue() ?? proto.Sessions;
            return proto;
        }
    }

}

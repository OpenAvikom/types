
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
        public Avikom.UnityTypes.Assistance.SessionSet Sessions;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SessionList proto)
        {

            if (Sessions == null) { Sessions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.SessionSet>(); }
            if (proto.Sessions.Count > 0)
            {
                Sessions.Clear();
                foreach (var value in proto.Sessions)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Session>();
                    tmp.SetValue(value);
                    Sessions.Add(tmp);
                }
                Sessions.Raise();
            }
        
            Raise();
        }

        public void SetValue(SessionList other)
        {
            if (!other) { return; }

            if (other.Sessions != null)
            {
                if (Sessions == null) { Sessions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.SessionSet>(); }
                Sessions.Clear();
                foreach (var elem in other.Sessions.Items)
                {
                    Sessions.Add(elem);
                }
                Sessions.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.SessionList GetValue()
        {
            var proto = new Avikom.Types.Assistance.SessionList();

            foreach (var value in Sessions.Items) { proto.Sessions.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

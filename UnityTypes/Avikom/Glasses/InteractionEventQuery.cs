
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Glasses
{

    /** This message is DEPRECATED; This message is used to query user interaction events of a particular session. 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/InteractionEventQuery")]
    public class InteractionEventQuery : GameEvent<InteractionEventQuery>, IGameEvent
    {
        public static Avikom.Types.Glasses.InteractionEventQuery TypeDefault = null;
        // id of the requested session
        public StringVariable SessionId;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Glasses.InteractionEventQuery proto)
        {

            if (SessionId == null) { SessionId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SessionId != StringVariable.TypeDefault)
            {
                SessionId.SetValue(proto.SessionId);
            }
            Raise();
        }

        public void SetValue(InteractionEventQuery other)
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
            Raise();
        }

        public Avikom.Types.Glasses.InteractionEventQuery GetValue()
        {
            var proto = new Avikom.Types.Glasses.InteractionEventQuery();
            proto.SessionId = SessionId?.GetValue() ?? proto.SessionId;
            return proto;
        }
    }

}

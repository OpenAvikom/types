
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message is used to initialized or request a session.
     @author Alexander McService Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SessionQuery")]
    public class SessionQuery : GameEvent<SessionQuery>, IGameEvent
    {
        public static Avikom.Types.Assistance.SessionQuery TypeDefault = null;
        // unique id of a session; will be created by `SessionService`
        public StringVariable Id;

        // user assigned to the session
        public UnsignedLongVariable UserId;

        // location assigned to the session
        public StringVariable SceneName;

        // task assigned to the session
        public StringVariable TaskName;

        // resolves assigned `user_id` from `username`
        public StringVariable Username;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SessionQuery proto)
        {

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.UserId != UnsignedLongVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }

            if (SceneName == null) { SceneName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SceneName != StringVariable.TypeDefault)
            {
                SceneName.SetValue(proto.SceneName);
            }

            if (TaskName == null) { TaskName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TaskName != StringVariable.TypeDefault)
            {
                TaskName.SetValue(proto.TaskName);
            }

            if (Username == null) { Username = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Username != StringVariable.TypeDefault)
            {
                Username.SetValue(proto.Username);
            }
            Raise();
        }

        public void SetValue(SessionQuery other)
        {
            if (!other) { return; }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }

            if (SceneName == null)
            {
                SceneName = other.SceneName;
            }
            else if (other.SceneName != null)
            {
                SceneName.SetValue(other.SceneName);
            }

            if (TaskName == null)
            {
                TaskName = other.TaskName;
            }
            else if (other.TaskName != null)
            {
                TaskName.SetValue(other.TaskName);
            }

            if (Username == null)
            {
                Username = other.Username;
            }
            else if (other.Username != null)
            {
                Username.SetValue(other.Username);
            }
            Raise();
        }

        public Avikom.Types.Assistance.SessionQuery GetValue()
        {
            var proto = new Avikom.Types.Assistance.SessionQuery();
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            proto.SceneName = SceneName?.GetValue() ?? proto.SceneName;
            proto.TaskName = TaskName?.GetValue() ?? proto.TaskName;
            proto.Username = Username?.GetValue() ?? proto.Username;
            return proto;
        }
    }

}

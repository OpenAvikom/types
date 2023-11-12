
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** Query an issue from the storage or the session manager. Fields can be combined and intersections will be returned.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueQuery")]
    public class IssueQuery : GameEvent<IssueQuery>, IGameEvent
    {
        public static Avikom.Types.Assistance.IssueQuery TypeDefault = null;
        // when set, the IssueList will only contain one element or an error is raised
        public StringVariable Id;

        // when set, only issues with this status will be returned
        public Avikom.UnityTypes.Assistance.IssueStatus Status;

        // when set, only issues assigned to the user will be returned
        public UnsignedLongVariable UserId;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.IssueQuery proto)
        {

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (Status == null) { Status = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.IssueStatus>(); }
            if (proto.Status != Avikom.UnityTypes.Assistance.IssueStatus.TypeDefault)
            {
                Status.SetValue(proto.Status);
            }

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.UserId != UnsignedLongVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }
            Raise();
        }

        public void SetValue(IssueQuery other)
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

            if (Status == null)
            {
                Status = other.Status;
            }
            else if (other.Status != null)
            {
                Status.SetValue(other.Status);
            }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }
            Raise();
        }

        public Avikom.Types.Assistance.IssueQuery GetValue()
        {
            var proto = new Avikom.Types.Assistance.IssueQuery();
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.Status = Status?.GetValue() ?? proto.Status;
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            return proto;
        }
    }

}

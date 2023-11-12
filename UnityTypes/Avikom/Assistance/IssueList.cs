
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A collection of `Issue` objects.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/IssueList")]
    public class IssueList : GameEvent<IssueList>, IGameEvent
    {
        public static Avikom.Types.Assistance.IssueList TypeDefault = null;

        public Avikom.UnityTypes.Assistance.Issue Issues;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.IssueList proto)
        {

            if (Issues == null) { Issues = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Issue>(); }
            if (proto.Issues != Avikom.UnityTypes.Assistance.Issue.TypeDefault)
            {
                Issues.SetValue(proto.Issues);
            }
            Raise();
        }

        public void SetValue(IssueList other)
        {
            if (!other) { return; }

            if (Issues == null)
            {
                Issues = other.Issues;
            }
            else if (other.Issues != null)
            {
                Issues.SetValue(other.Issues);
            }
            Raise();
        }

        public Avikom.Types.Assistance.IssueList GetValue()
        {
            var proto = new Avikom.Types.Assistance.IssueList();
            proto.Issues = Issues?.GetValue() ?? proto.Issues;
            return proto;
        }
    }

}

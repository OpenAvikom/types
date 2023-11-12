
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

        public Avikom.UnityTypes.Assistance.IssueSet Issues;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.IssueList proto)
        {

            if (Issues == null) { Issues = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.IssueSet>(); }
            if (proto.Issues.Count > 0)
            {
                Issues.Clear();
                foreach (var value in proto.Issues)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Issue>();
                    tmp.SetValue(value);
                    Issues.Add(tmp);
                }
                Issues.Raise();
            }
        
            Raise();
        }

        public void SetValue(IssueList other)
        {
            if (!other) { return; }

            if (other.Issues != null)
            {
                if (Issues == null) { Issues = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.IssueSet>(); }
                Issues.Clear();
                foreach (var elem in other.Issues.Items)
                {
                    Issues.Add(elem);
                }
                Issues.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.IssueList GetValue()
        {
            var proto = new Avikom.Types.Assistance.IssueList();

            foreach (var value in Issues.Items) { proto.Issues.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

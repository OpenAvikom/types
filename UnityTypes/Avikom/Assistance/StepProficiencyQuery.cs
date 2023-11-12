
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A query to retrieve `StepProficiencies` for task steps or `SplitProcedureResults` for taks
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/StepProficiencyQuery")]
    public class StepProficiencyQuery : GameEvent<StepProficiencyQuery>, IGameEvent
    {
        public static Avikom.Types.Assistance.StepProficiencyQuery TypeDefault = null;
        // ID of the user in question
        public UnsignedIntVariable UserId;

        // either a task step name (for proficiencies) or a task name (for split procedure results)
        public StringVariable TargetName;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.StepProficiencyQuery proto)
        {

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedIntVariable>(); }
            if (proto.UserId != UnsignedIntVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }

            if (TargetName == null) { TargetName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TargetName != StringVariable.TypeDefault)
            {
                TargetName.SetValue(proto.TargetName);
            }
            Raise();
        }

        public void SetValue(StepProficiencyQuery other)
        {
            if (!other) { return; }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }

            if (TargetName == null)
            {
                TargetName = other.TargetName;
            }
            else if (other.TargetName != null)
            {
                TargetName.SetValue(other.TargetName);
            }
            Raise();
        }

        public Avikom.Types.Assistance.StepProficiencyQuery GetValue()
        {
            var proto = new Avikom.Types.Assistance.StepProficiencyQuery();
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            proto.TargetName = TargetName?.GetValue() ?? proto.TargetName;
            return proto;
        }
    }

}

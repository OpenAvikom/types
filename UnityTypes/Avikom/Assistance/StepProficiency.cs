
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A message to describe the step proficiency of a user. 
     This includes the currently required assistance level but also parameters to determine when or if AVIKOM will attempt to reduce the assistance level.
     @author: Alexander Neumann <alneuma@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/StepProficiency")]
    public class StepProficiency : GameEvent<StepProficiency>, IGameEvent
    {
        public static Avikom.Types.Assistance.StepProficiency TypeDefault = null;
        // currently required assistance
        public Avikom.UnityTypes.Assistance.AssistanceLevel RequiredAssistance;

        // user requiring assistance
        public Avikom.UnityTypes.Generic.User User;

        // task step to assist
        public Avikom.UnityTypes.Assistance.TaskStep Step;

        // tendency of the current assistance level; raning from -1 to +1
        public FloatVariable Tendency;

        // factor to reduce `tendency` when a task was conducted successfully
        public FloatVariable AssistanceDecrease;

        // when this level is reached, assistance will not decay any further
        public Avikom.UnityTypes.Assistance.AssistanceLevel MinimalAssistance;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.StepProficiency proto)
        {

            if (RequiredAssistance == null) { RequiredAssistance = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.AssistanceLevel>(); }
            if (proto.RequiredAssistance != Avikom.UnityTypes.Assistance.AssistanceLevel.TypeDefault)
            {
                RequiredAssistance.SetValue(proto.RequiredAssistance);
            }

            if (User == null) { User = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.User != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                User.SetValue(proto.User);
            }

            if (Step == null) { Step = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStep>(); }
            if (proto.Step != Avikom.UnityTypes.Assistance.TaskStep.TypeDefault)
            {
                Step.SetValue(proto.Step);
            }

            if (Tendency == null) { Tendency = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Tendency != FloatVariable.TypeDefault)
            {
                Tendency.SetValue(proto.Tendency);
            }

            if (AssistanceDecrease == null) { AssistanceDecrease = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.AssistanceDecrease != FloatVariable.TypeDefault)
            {
                AssistanceDecrease.SetValue(proto.AssistanceDecrease);
            }

            if (MinimalAssistance == null) { MinimalAssistance = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.AssistanceLevel>(); }
            if (proto.MinimalAssistance != Avikom.UnityTypes.Assistance.AssistanceLevel.TypeDefault)
            {
                MinimalAssistance.SetValue(proto.MinimalAssistance);
            }
            Raise();
        }

        public void SetValue(StepProficiency other)
        {
            if (!other) { return; }

            if (RequiredAssistance == null)
            {
                RequiredAssistance = other.RequiredAssistance;
            }
            else if (other.RequiredAssistance != null)
            {
                RequiredAssistance.SetValue(other.RequiredAssistance);
            }

            if (User == null)
            {
                User = other.User;
            }
            else if (other.User != null)
            {
                User.SetValue(other.User);
            }

            if (Step == null)
            {
                Step = other.Step;
            }
            else if (other.Step != null)
            {
                Step.SetValue(other.Step);
            }

            if (Tendency == null)
            {
                Tendency = other.Tendency;
            }
            else if (other.Tendency != null)
            {
                Tendency.SetValue(other.Tendency);
            }

            if (AssistanceDecrease == null)
            {
                AssistanceDecrease = other.AssistanceDecrease;
            }
            else if (other.AssistanceDecrease != null)
            {
                AssistanceDecrease.SetValue(other.AssistanceDecrease);
            }

            if (MinimalAssistance == null)
            {
                MinimalAssistance = other.MinimalAssistance;
            }
            else if (other.MinimalAssistance != null)
            {
                MinimalAssistance.SetValue(other.MinimalAssistance);
            }
            Raise();
        }

        public Avikom.Types.Assistance.StepProficiency GetValue()
        {
            var proto = new Avikom.Types.Assistance.StepProficiency();
            proto.RequiredAssistance = RequiredAssistance?.GetValue() ?? proto.RequiredAssistance;
            proto.User = User?.GetValue() ?? proto.User;
            proto.Step = Step?.GetValue() ?? proto.Step;
            proto.Tendency = Tendency?.GetValue() ?? proto.Tendency;
            proto.AssistanceDecrease = AssistanceDecrease?.GetValue() ?? proto.AssistanceDecrease;
            proto.MinimalAssistance = MinimalAssistance?.GetValue() ?? proto.MinimalAssistance;
            return proto;
        }
    }

}

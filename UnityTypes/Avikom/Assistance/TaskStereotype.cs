
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This messages classifies the assistance mechanism needed for a `TaskStep`.
     Paramaters may contain variable names in `{curly brackets}`.
     These should be resolved during runtime with the session's variable content.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStereotype")]
    public class TaskStereotype : GameEvent<TaskStereotype>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskStereotype TypeDefault = null;
        // defines the kind of action a user can conduct to process this task
        public Avikom.UnityTypes.Assistance.TaskStereotypeCategory Category;

        // a set of choices a user can choose; will be only be considered for tasks where decisions have to be made
        public Avikom.UnityTypes.Assistance.ChoicesConfig Choices;

        // the name of a  virtual or real object of central importance for that task (e.g. the target location during guidance)
        public StringVariable Target;

        // a set of services that can be used to solve that task
        public Avikom.UnityTypes.Assistance.ServiceConfigurationSet Services;

        // the default assistance for this step if no step proficiency is available
        public Avikom.UnityTypes.Assistance.AssistanceLevel DefaultAssistance;

        // overrides the category-induced minimal assistance levels but cannot be lower
        public Avikom.UnityTypes.Assistance.AssistanceLevel MinimalAssistance;

        // factor to reduce `tendency` when a task was conducted successfully, this will be combined with user preferences; 0 is considered unset and will be ignored
        public FloatVariable AssistanceDecrease;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskStereotype proto)
        {

            if (Category == null) { Category = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStereotypeCategory>(); }
            if (proto.Category != Avikom.UnityTypes.Assistance.TaskStereotypeCategory.TypeDefault)
            {
                Category.SetValue(proto.Category);
            }

            if (Choices == null) { Choices = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ChoicesConfig>(); }
            if (proto.Choices != Avikom.UnityTypes.Assistance.ChoicesConfig.TypeDefault)
            {
                Choices.SetValue(proto.Choices);
            }

            if (Target == null) { Target = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Target != StringVariable.TypeDefault)
            {
                Target.SetValue(proto.Target);
            }

            if (Services == null) { Services = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ServiceConfigurationSet>(); }
            if (proto.Services.Count > 0)
            {
                Services.Clear();
                foreach (var value in proto.Services)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ServiceConfiguration>();
                    tmp.SetValue(value);
                    Services.Add(tmp);
                }
                Services.Raise();
            }
        

            if (DefaultAssistance == null) { DefaultAssistance = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.AssistanceLevel>(); }
            if (proto.DefaultAssistance != Avikom.UnityTypes.Assistance.AssistanceLevel.TypeDefault)
            {
                DefaultAssistance.SetValue(proto.DefaultAssistance);
            }

            if (MinimalAssistance == null) { MinimalAssistance = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.AssistanceLevel>(); }
            if (proto.MinimalAssistance != Avikom.UnityTypes.Assistance.AssistanceLevel.TypeDefault)
            {
                MinimalAssistance.SetValue(proto.MinimalAssistance);
            }

            if (AssistanceDecrease == null) { AssistanceDecrease = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.AssistanceDecrease != FloatVariable.TypeDefault)
            {
                AssistanceDecrease.SetValue(proto.AssistanceDecrease);
            }
            Raise();
        }

        public void SetValue(TaskStereotype other)
        {
            if (!other) { return; }

            if (Category == null)
            {
                Category = other.Category;
            }
            else if (other.Category != null)
            {
                Category.SetValue(other.Category);
            }

            if (Choices == null)
            {
                Choices = other.Choices;
            }
            else if (other.Choices != null)
            {
                Choices.SetValue(other.Choices);
            }

            if (Target == null)
            {
                Target = other.Target;
            }
            else if (other.Target != null)
            {
                Target.SetValue(other.Target);
            }

            if (other.Services != null)
            {
                if (Services == null) { Services = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ServiceConfigurationSet>(); }
                Services.Clear();
                foreach (var elem in other.Services.Items)
                {
                    Services.Add(elem);
                }
                Services.Raise();
            }

            if (DefaultAssistance == null)
            {
                DefaultAssistance = other.DefaultAssistance;
            }
            else if (other.DefaultAssistance != null)
            {
                DefaultAssistance.SetValue(other.DefaultAssistance);
            }

            if (MinimalAssistance == null)
            {
                MinimalAssistance = other.MinimalAssistance;
            }
            else if (other.MinimalAssistance != null)
            {
                MinimalAssistance.SetValue(other.MinimalAssistance);
            }

            if (AssistanceDecrease == null)
            {
                AssistanceDecrease = other.AssistanceDecrease;
            }
            else if (other.AssistanceDecrease != null)
            {
                AssistanceDecrease.SetValue(other.AssistanceDecrease);
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskStereotype GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskStereotype();
            proto.Category = Category?.GetValue() ?? proto.Category;
            proto.Choices = Choices?.GetValue() ?? proto.Choices;
            proto.Target = Target?.GetValue() ?? proto.Target;

            foreach (var value in Services.Items) { proto.Services.Add(value.GetValue()); }
                        
            proto.DefaultAssistance = DefaultAssistance?.GetValue() ?? proto.DefaultAssistance;
            proto.MinimalAssistance = MinimalAssistance?.GetValue() ?? proto.MinimalAssistance;
            proto.AssistanceDecrease = AssistanceDecrease?.GetValue() ?? proto.AssistanceDecrease;
            return proto;
        }
    }

}

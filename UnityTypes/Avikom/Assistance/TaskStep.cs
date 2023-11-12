
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a task step. A step describes an individual operation of a certain stereotype that 
     should be compatible with the 'Basic Action Concept' (BAC) of SDA-M.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/TaskStep")]
    public class TaskStep : GameEvent<TaskStep>, IGameEvent
    {
        public static Avikom.Types.Assistance.TaskStep TypeDefault = null;
        // globally unique step name
        public StringVariable Name;

        // defines the kind of action to be conducted; defines the possible actions a user may conduct to process this step
        public Avikom.UnityTypes.Assistance.TaskStereotype Type;

        // textual instructions for this task step
        public Avikom.UnityTypes.Assistance.InstructionText Instructions;

        // media content for this task step, includes prefabs and such a like
        public Avikom.UnityTypes.Assistance.InstructionMedia Media;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.TaskStep proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (Type == null) { Type = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStereotype>(); }
            if (proto.Type != Avikom.UnityTypes.Assistance.TaskStereotype.TypeDefault)
            {
                Type.SetValue(proto.Type);
            }

            if (Instructions == null) { Instructions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionText>(); }
            if (proto.Instructions != Avikom.UnityTypes.Assistance.InstructionText.TypeDefault)
            {
                Instructions.SetValue(proto.Instructions);
            }

            if (Media == null) { Media = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMedia>(); }
            if (proto.Media != Avikom.UnityTypes.Assistance.InstructionMedia.TypeDefault)
            {
                Media.SetValue(proto.Media);
            }
            Raise();
        }

        public void SetValue(TaskStep other)
        {
            if (!other) { return; }

            if (Name == null)
            {
                Name = other.Name;
            }
            else if (other.Name != null)
            {
                Name.SetValue(other.Name);
            }

            if (Type == null)
            {
                Type = other.Type;
            }
            else if (other.Type != null)
            {
                Type.SetValue(other.Type);
            }

            if (Instructions == null)
            {
                Instructions = other.Instructions;
            }
            else if (other.Instructions != null)
            {
                Instructions.SetValue(other.Instructions);
            }

            if (Media == null)
            {
                Media = other.Media;
            }
            else if (other.Media != null)
            {
                Media.SetValue(other.Media);
            }
            Raise();
        }

        public Avikom.Types.Assistance.TaskStep GetValue()
        {
            var proto = new Avikom.Types.Assistance.TaskStep();
            proto.Name = Name?.GetValue() ?? proto.Name;
            proto.Type = Type?.GetValue() ?? proto.Type;
            proto.Instructions = Instructions?.GetValue() ?? proto.Instructions;
            proto.Media = Media?.GetValue() ?? proto.Media;
            return proto;
        }
    }

}

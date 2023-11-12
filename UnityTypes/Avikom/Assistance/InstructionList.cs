
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of instructions with resolved fields.
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionList")]
    public class InstructionList : GameEvent<InstructionList>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionList TypeDefault = null;
        // textual instructions for this task step
        public Avikom.UnityTypes.Assistance.InstructionText Instructions;

        // media content for this task step; includes prefabs and world objects
        public Avikom.UnityTypes.Assistance.InstructionMedia Media;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionList proto)
        {

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

        public void SetValue(InstructionList other)
        {
            if (!other) { return; }

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

        public Avikom.Types.Assistance.InstructionList GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionList();
            proto.Instructions = Instructions?.GetValue() ?? proto.Instructions;
            proto.Media = Media?.GetValue() ?? proto.Media;
            return proto;
        }
    }

}

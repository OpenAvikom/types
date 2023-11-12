
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message describes the common base for an instruction.
     Every instruction has an assistance level and can be modaly modulated
     They should all be compatible with the 'Basic Action Concept' (BAC) of SDA-M.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/InstructionMeta")]
    public class InstructionMeta : GameEvent<InstructionMeta>, IGameEvent
    {
        public static Avikom.Types.Assistance.InstructionMeta TypeDefault = null;
        // the targeted assistance level, this instruction wont be available for users with less assistance requirements
        public Avikom.UnityTypes.Assistance.AssistanceLevel AssistanceLevel;

        // whether an instruction should be preferably presented in a certain modality and whether a modality in generally unsuited for that introduction.
        public Avikom.UnityTypes.Generic.Modality ModalBias;

        // name of the scene/task asset this object should be referenced to;
        public StringVariable Location;

        // relative offset to the mentioned location
        public Avikom.UnityTypes.Unity.Transpose Transpose;

        // an optional id to reference the instruction later
        public StringVariable Id;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionMeta proto)
        {

            if (AssistanceLevel == null) { AssistanceLevel = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.AssistanceLevel>(); }
            if (proto.AssistanceLevel != Avikom.UnityTypes.Assistance.AssistanceLevel.TypeDefault)
            {
                AssistanceLevel.SetValue(proto.AssistanceLevel);
            }

            if (ModalBias == null) { ModalBias = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Modality>(); }
            if (proto.ModalBias != Avikom.UnityTypes.Generic.Modality.TypeDefault)
            {
                ModalBias.SetValue(proto.ModalBias);
            }

            if (Location == null) { Location = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Location != StringVariable.TypeDefault)
            {
                Location.SetValue(proto.Location);
            }

            if (Transpose == null) { Transpose = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.Transpose>(); }
            if (proto.Transpose != Avikom.UnityTypes.Unity.Transpose.TypeDefault)
            {
                Transpose.SetValue(proto.Transpose);
            }

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }
            Raise();
        }

        public void SetValue(InstructionMeta other)
        {
            if (!other) { return; }

            if (AssistanceLevel == null)
            {
                AssistanceLevel = other.AssistanceLevel;
            }
            else if (other.AssistanceLevel != null)
            {
                AssistanceLevel.SetValue(other.AssistanceLevel);
            }

            if (ModalBias == null)
            {
                ModalBias = other.ModalBias;
            }
            else if (other.ModalBias != null)
            {
                ModalBias.SetValue(other.ModalBias);
            }

            if (Location == null)
            {
                Location = other.Location;
            }
            else if (other.Location != null)
            {
                Location.SetValue(other.Location);
            }

            if (Transpose == null)
            {
                Transpose = other.Transpose;
            }
            else if (other.Transpose != null)
            {
                Transpose.SetValue(other.Transpose);
            }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }
            Raise();
        }

        public Avikom.Types.Assistance.InstructionMeta GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionMeta();
            proto.AssistanceLevel = AssistanceLevel?.GetValue() ?? proto.AssistanceLevel;
            proto.ModalBias = ModalBias?.GetValue() ?? proto.ModalBias;
            proto.Location = Location?.GetValue() ?? proto.Location;
            proto.Transpose = Transpose?.GetValue() ?? proto.Transpose;
            proto.Id = Id?.GetValue() ?? proto.Id;
            return proto;
        }
    }

}

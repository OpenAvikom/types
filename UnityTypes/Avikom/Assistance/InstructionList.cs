
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
        public Avikom.UnityTypes.Assistance.InstructionTextSet Instructions;

        // media content for this task step; includes prefabs and world objects
        public Avikom.UnityTypes.Assistance.InstructionMediaSet Media;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.InstructionList proto)
        {

            if (Instructions == null) { Instructions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionTextSet>(); }
            if (proto.Instructions.Count > 0)
            {
                Instructions.Clear();
                foreach (var value in proto.Instructions)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionText>();
                    tmp.SetValue(value);
                    Instructions.Add(tmp);
                }
                Instructions.Raise();
            }
        

            if (Media == null) { Media = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMediaSet>(); }
            if (proto.Media.Count > 0)
            {
                Media.Clear();
                foreach (var value in proto.Media)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMedia>();
                    tmp.SetValue(value);
                    Media.Add(tmp);
                }
                Media.Raise();
            }
        
            Raise();
        }

        public void SetValue(InstructionList other)
        {
            if (!other) { return; }

            if (other.Instructions != null)
            {
                if (Instructions == null) { Instructions = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionTextSet>(); }
                Instructions.Clear();
                foreach (var elem in other.Instructions.Items)
                {
                    Instructions.Add(elem);
                }
                Instructions.Raise();
            }

            if (other.Media != null)
            {
                if (Media == null) { Media = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.InstructionMediaSet>(); }
                Media.Clear();
                foreach (var elem in other.Media.Items)
                {
                    Media.Add(elem);
                }
                Media.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.InstructionList GetValue()
        {
            var proto = new Avikom.Types.Assistance.InstructionList();

            foreach (var value in Instructions.Items) { proto.Instructions.Add(value.GetValue()); }
                        

            foreach (var value in Media.Items) { proto.Media.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}

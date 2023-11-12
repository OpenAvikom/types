
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Glasses
{

    /** This message describes a user interaction with a virtual or real-world artifact.
     The kind and target of an interaction is communicated.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Glasses/InteractionEvent")]
    public class InteractionEvent : GameEvent<InteractionEvent>, IGameEvent
    {
        public static Avikom.Types.Glasses.InteractionEvent TypeDefault = null;
        // type of interaction (e.g. click, touch, drag)
        public Avikom.UnityTypes.Glasses.InteractionType Type;

        // the unique name of the targt object
        public StringVariable Target;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Glasses.InteractionEvent proto)
        {

            if (Type == null) { Type = ScriptableObject.CreateInstance<Avikom.UnityTypes.Glasses.InteractionType>(); }
            if (proto.Type != Avikom.UnityTypes.Glasses.InteractionType.TypeDefault)
            {
                Type.SetValue(proto.Type);
            }

            if (Target == null) { Target = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Target != StringVariable.TypeDefault)
            {
                Target.SetValue(proto.Target);
            }
            Raise();
        }

        public void SetValue(InteractionEvent other)
        {
            if (!other) { return; }

            if (Type == null)
            {
                Type = other.Type;
            }
            else if (other.Type != null)
            {
                Type.SetValue(other.Type);
            }

            if (Target == null)
            {
                Target = other.Target;
            }
            else if (other.Target != null)
            {
                Target.SetValue(other.Target);
            }
            Raise();
        }

        public Avikom.Types.Glasses.InteractionEvent GetValue()
        {
            var proto = new Avikom.Types.Glasses.InteractionEvent();
            proto.Type = Type?.GetValue() ?? proto.Type;
            proto.Target = Target?.GetValue() ?? proto.Target;
            return proto;
        }
    }

}

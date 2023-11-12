
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message represents a choice a user can select. It is commonly part of a selection of choices 
     in a ChoiceConfig.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ChoiceItem")]
    public class ChoiceItem : GameEvent<ChoiceItem>, IGameEvent
    {
        public static Avikom.Types.Assistance.ChoiceItem TypeDefault = null;
        // The value a peer should return when a user made a choice.
        public StringVariable Value;

        // If set, present this (human readable) label instead of the actual choice value to the user.
        public StringVariable Label;

        // Represents the current selection state of the item.
        public BoolVariable Selected;

        // Whether this item can currently be selected or not. Note that `true` also means an item cannot be deselected.
        public BoolVariable Disabled;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.ChoiceItem proto)
        {

            if (Value == null) { Value = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Value != StringVariable.TypeDefault)
            {
                Value.SetValue(proto.Value);
            }

            if (Label == null) { Label = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Label != StringVariable.TypeDefault)
            {
                Label.SetValue(proto.Label);
            }

            if (Selected == null) { Selected = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Selected.SetValue(proto.Selected);
            }

            if (Disabled == null) { Disabled = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Disabled.SetValue(proto.Disabled);
            }
            Raise();
        }

        public void SetValue(ChoiceItem other)
        {
            if (!other) { return; }

            if (Value == null)
            {
                Value = other.Value;
            }
            else if (other.Value != null)
            {
                Value.SetValue(other.Value);
            }

            if (Label == null)
            {
                Label = other.Label;
            }
            else if (other.Label != null)
            {
                Label.SetValue(other.Label);
            }

            if (Selected == null)
            {
                Selected = other.Selected;
            }
            else if (other.Selected != null)
            {
                Selected.SetValue(other.Selected);
            }

            if (Disabled == null)
            {
                Disabled = other.Disabled;
            }
            else if (other.Disabled != null)
            {
                Disabled.SetValue(other.Disabled);
            }
            Raise();
        }

        public Avikom.Types.Assistance.ChoiceItem GetValue()
        {
            var proto = new Avikom.Types.Assistance.ChoiceItem();
            proto.Value = Value?.GetValue() ?? proto.Value;
            proto.Label = Label?.GetValue() ?? proto.Label;
            proto.Selected = Selected?.GetValue() ?? proto.Selected;
            proto.Disabled = Disabled?.GetValue() ?? proto.Disabled;
            return proto;
        }
    }

}

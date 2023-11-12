
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a choice a peer/user can make.
     It contains state information for each individual choice that can be made
     to enable multiple selections in a looped interaction.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ChoicesConfig")]
    public class ChoicesConfig : GameEvent<ChoicesConfig>, IGameEvent
    {
        public static Avikom.Types.Assistance.ChoicesConfig TypeDefault = null;
        // a list of choices to choose from
        public Avikom.UnityTypes.Assistance.ChoiceItemSet Items;

        // If set, this value may be returned when no choice has been made. If not, a valid item value must be returned.
        public StringVariable DefaultValue;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.ChoicesConfig proto)
        {

            if (Items == null) { Items = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ChoiceItemSet>(); }
            if (proto.Items.Count > 0)
            {
                Items.Clear();
                foreach (var value in proto.Items)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ChoiceItem>();
                    tmp.SetValue(value);
                    Items.Add(tmp);
                }
                Items.Raise();
            }
        

            if (DefaultValue == null) { DefaultValue = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.DefaultValue != StringVariable.TypeDefault)
            {
                DefaultValue.SetValue(proto.DefaultValue);
            }
            Raise();
        }

        public void SetValue(ChoicesConfig other)
        {
            if (!other) { return; }

            if (other.Items != null)
            {
                if (Items == null) { Items = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ChoiceItemSet>(); }
                Items.Clear();
                foreach (var elem in other.Items.Items)
                {
                    Items.Add(elem);
                }
                Items.Raise();
            }

            if (DefaultValue == null)
            {
                DefaultValue = other.DefaultValue;
            }
            else if (other.DefaultValue != null)
            {
                DefaultValue.SetValue(other.DefaultValue);
            }
            Raise();
        }

        public Avikom.Types.Assistance.ChoicesConfig GetValue()
        {
            var proto = new Avikom.Types.Assistance.ChoicesConfig();

            foreach (var value in Items.Items) { proto.Items.Add(value.GetValue()); }
                        
            proto.DefaultValue = DefaultValue?.GetValue() ?? proto.DefaultValue;
            return proto;
        }
    }

}

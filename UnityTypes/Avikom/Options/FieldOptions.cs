
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Options
{

    /** This is a meta message which is not supposed to be shared but used to define database-related properties.
     These properties will be evaluated by the protoc converter plugins to determine -- for instance -- the mongoDB schema required to store and retrieve a decorated message.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Options/FieldOptions")]
    public class FieldOptions : GameEvent<FieldOptions>, IGameEvent
    {
        public static Avikom.Types.Options.FieldOptions TypeDefault = null;
        // marks the field as index; NOTE: unused; use 'unique' instead
        public BoolVariable Index;

        // interprete field as key for the schema; will generate approriate helper functions to retrieve documents
        public BoolVariable Unique;

        // define default value for an (optional) field
        public StringVariable Default;

        // regex for data validation; NOTE: unused
        public StringVariable Match;

        // minimal value for a field; NOTE: unused
        public StringVariable Min;

        // mark a field as unchangeable; NOTE: unused
        public BoolVariable Immutable;

        // increase the index automatically; NOTE: unused
        public BoolVariable AutoIndex;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Options.FieldOptions proto)
        {

            if (Index == null) { Index = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Index.SetValue(proto.Index);
            }

            if (Unique == null) { Unique = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Unique.SetValue(proto.Unique);
            }

            if (Default == null) { Default = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Default != StringVariable.TypeDefault)
            {
                Default.SetValue(proto.Default);
            }

            if (Match == null) { Match = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Match != StringVariable.TypeDefault)
            {
                Match.SetValue(proto.Match);
            }

            if (Min == null) { Min = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Min != StringVariable.TypeDefault)
            {
                Min.SetValue(proto.Min);
            }

            if (Immutable == null) { Immutable = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Immutable.SetValue(proto.Immutable);
            }

            if (AutoIndex == null) { AutoIndex = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                AutoIndex.SetValue(proto.AutoIndex);
            }
            Raise();
        }

        public void SetValue(FieldOptions other)
        {
            if (!other) { return; }

            if (Index == null)
            {
                Index = other.Index;
            }
            else if (other.Index != null)
            {
                Index.SetValue(other.Index);
            }

            if (Unique == null)
            {
                Unique = other.Unique;
            }
            else if (other.Unique != null)
            {
                Unique.SetValue(other.Unique);
            }

            if (Default == null)
            {
                Default = other.Default;
            }
            else if (other.Default != null)
            {
                Default.SetValue(other.Default);
            }

            if (Match == null)
            {
                Match = other.Match;
            }
            else if (other.Match != null)
            {
                Match.SetValue(other.Match);
            }

            if (Min == null)
            {
                Min = other.Min;
            }
            else if (other.Min != null)
            {
                Min.SetValue(other.Min);
            }

            if (Immutable == null)
            {
                Immutable = other.Immutable;
            }
            else if (other.Immutable != null)
            {
                Immutable.SetValue(other.Immutable);
            }

            if (AutoIndex == null)
            {
                AutoIndex = other.AutoIndex;
            }
            else if (other.AutoIndex != null)
            {
                AutoIndex.SetValue(other.AutoIndex);
            }
            Raise();
        }

        public Avikom.Types.Options.FieldOptions GetValue()
        {
            var proto = new Avikom.Types.Options.FieldOptions();
            proto.Index = Index?.GetValue() ?? proto.Index;
            proto.Unique = Unique?.GetValue() ?? proto.Unique;
            proto.Default = Default?.GetValue() ?? proto.Default;
            proto.Match = Match?.GetValue() ?? proto.Match;
            proto.Min = Min?.GetValue() ?? proto.Min;
            proto.Immutable = Immutable?.GetValue() ?? proto.Immutable;
            proto.AutoIndex = AutoIndex?.GetValue() ?? proto.AutoIndex;
            return proto;
        }
    }

}

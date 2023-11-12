
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Camunda
{

    /** This message describes a Camunda variable.
     Values of commonly stored as a string and are parsed according to the type mentioned in `type` when needed.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Camunda/Variable")]
    public class Variable : GameEvent<Variable>, IGameEvent
    {
        public static Avikom.Types.Camunda.Variable TypeDefault = null;
        // name of the variable
        public StringVariable Name;

        // variable type
        public Avikom.UnityTypes.Camunda.ValueType ValueType;

        // string-encoded variable value
        public StringVariable Value;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Camunda.Variable proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (ValueType == null) { ValueType = ScriptableObject.CreateInstance<Avikom.UnityTypes.Camunda.ValueType>(); }
            if (proto.ValueType != Avikom.UnityTypes.Camunda.ValueType.TypeDefault)
            {
                ValueType.SetValue(proto.ValueType);
            }

            if (Value == null) { Value = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Value != StringVariable.TypeDefault)
            {
                Value.SetValue(proto.Value);
            }
            Raise();
        }

        public void SetValue(Variable other)
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

            if (ValueType == null)
            {
                ValueType = other.ValueType;
            }
            else if (other.ValueType != null)
            {
                ValueType.SetValue(other.ValueType);
            }

            if (Value == null)
            {
                Value = other.Value;
            }
            else if (other.Value != null)
            {
                Value.SetValue(other.Value);
            }
            Raise();
        }

        public Avikom.Types.Camunda.Variable GetValue()
        {
            var proto = new Avikom.Types.Camunda.Variable();
            proto.Name = Name?.GetValue() ?? proto.Name;
            proto.ValueType = ValueType?.GetValue() ?? proto.ValueType;
            proto.Value = Value?.GetValue() ?? proto.Value;
            return proto;
        }
    }

}

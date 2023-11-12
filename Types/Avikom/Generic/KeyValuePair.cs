// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/generic/key_value_pair.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Generic {

  /// <summary>Holder for reflection information generated from avikom/generic/key_value_pair.proto</summary>
  public static partial class KeyValuePairReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/generic/key_value_pair.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeyValuePairReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNhdmlrb20vZ2VuZXJpYy9rZXlfdmFsdWVfcGFpci5wcm90bxIOYXZpa29t",
            "LmdlbmVyaWMiKgoMS2V5VmFsdWVQYWlyEgsKA2tleRgBIAEoCRINCgV2YWx1",
            "ZRgCIAEoCUJsChhhcHAuYXZpa29tLnR5cGVzLmdlbmVyaWNaOWdpdGxhYi51",
            "Yi51bmktYmllbGVmZWxkLmRlL2F2aWtvbS9nby10eXBlcy9hdmlrb20vZ2Vu",
            "ZXJpY6oCFEF2aWtvbS5UeXBlcy5HZW5lcmljYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Generic.KeyValuePair), global::Avikom.Types.Generic.KeyValuePair.Parser, new[]{ "Key", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// This message is used to transfer associated information (i.e. slots extracted by rasa). 
  /// @author Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public sealed partial class KeyValuePair : pb::IMessage<KeyValuePair> {
    private static readonly pb::MessageParser<KeyValuePair> _parser = new pb::MessageParser<KeyValuePair>(() => new KeyValuePair());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeyValuePair> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Generic.KeyValuePairReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValuePair() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValuePair(KeyValuePair other) : this() {
      key_ = other.key_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValuePair Clone() {
      return new KeyValuePair(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    /// <summary>
    //// defines the value data type; informs consumer how to parse value
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private string value_ = "";
    /// <summary>
    //// value holds information serialized as string and needs to be parsed by consumer
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeyValuePair);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeyValuePair other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeyValuePair other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Key = input.ReadString();
            break;
          }
          case 18: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
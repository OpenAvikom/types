// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/choice_item.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/choice_item.proto</summary>
  public static partial class ChoiceItemReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/choice_item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChoiceItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNhdmlrb20vYXNzaXN0YW5jZS9jaG9pY2VfaXRlbS5wcm90bxIRYXZpa29t",
            "LmFzc2lzdGFuY2UiTgoKQ2hvaWNlSXRlbRINCgV2YWx1ZRgBIAEoCRINCgVs",
            "YWJlbBgCIAEoCRIQCghzZWxlY3RlZBgDIAEoCBIQCghkaXNhYmxlZBgEIAEo",
            "CEJ1ChthcHAuYXZpa29tLnR5cGVzLmFzc2lzdGFuY2VaPGdpdGxhYi51Yi51",
            "bmktYmllbGVmZWxkLmRlL2F2aWtvbS9nby10eXBlcy9hdmlrb20vYXNzaXN0",
            "YW5jZaoCF0F2aWtvbS5UeXBlcy5Bc3Npc3RhbmNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.ChoiceItem), global::Avikom.Types.Assistance.ChoiceItem.Parser, new[]{ "Value", "Label", "Selected", "Disabled" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// This message represents a choice a user can select. It is commonly part of a selection of choices 
  /// in a ChoiceConfig.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class ChoiceItem : pb::IMessage<ChoiceItem> {
    private static readonly pb::MessageParser<ChoiceItem> _parser = new pb::MessageParser<ChoiceItem>(() => new ChoiceItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChoiceItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.ChoiceItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChoiceItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChoiceItem(ChoiceItem other) : this() {
      value_ = other.value_;
      label_ = other.label_;
      selected_ = other.selected_;
      disabled_ = other.disabled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChoiceItem Clone() {
      return new ChoiceItem(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    /// <summary>
    //// The value a peer should return when a user made a choice.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 2;
    private string label_ = "";
    /// <summary>
    //// If set, present this (human readable) label instead of the actual choice value to the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "selected" field.</summary>
    public const int SelectedFieldNumber = 3;
    private bool selected_;
    /// <summary>
    //// Represents the current selection state of the item.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Selected {
      get { return selected_; }
      set {
        selected_ = value;
      }
    }

    /// <summary>Field number for the "disabled" field.</summary>
    public const int DisabledFieldNumber = 4;
    private bool disabled_;
    /// <summary>
    //// Whether this item can currently be selected or not. Note that `true` also means an item cannot be deselected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Disabled {
      get { return disabled_; }
      set {
        disabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChoiceItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChoiceItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      if (Label != other.Label) return false;
      if (Selected != other.Selected) return false;
      if (Disabled != other.Disabled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Selected != false) hash ^= Selected.GetHashCode();
      if (Disabled != false) hash ^= Disabled.GetHashCode();
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
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Label);
      }
      if (Selected != false) {
        output.WriteRawTag(24);
        output.WriteBool(Selected);
      }
      if (Disabled != false) {
        output.WriteRawTag(32);
        output.WriteBool(Disabled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Selected != false) {
        size += 1 + 1;
      }
      if (Disabled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChoiceItem other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Selected != false) {
        Selected = other.Selected;
      }
      if (other.Disabled != false) {
        Disabled = other.Disabled;
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
            Value = input.ReadString();
            break;
          }
          case 18: {
            Label = input.ReadString();
            break;
          }
          case 24: {
            Selected = input.ReadBool();
            break;
          }
          case 32: {
            Disabled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

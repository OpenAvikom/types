// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/runtime_step_list.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/runtime_step_list.proto</summary>
  public static partial class RuntimeStepListReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/runtime_step_list.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RuntimeStepListReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilhdmlrb20vYXNzaXN0YW5jZS9ydW50aW1lX3N0ZXBfbGlzdC5wcm90bxIR",
            "YXZpa29tLmFzc2lzdGFuY2UaKWF2aWtvbS9hc3Npc3RhbmNlL3J1bnRpbWVf",
            "dGFza19zdGVwLnByb3RvGhlhdmlrb20vZ2VuZXJpYy9wZWVyLnByb3RvImkK",
            "D1J1bnRpbWVTdGVwTGlzdBIxCgVzdGVwcxgBIAMoCzIiLmF2aWtvbS5hc3Np",
            "c3RhbmNlLlJ1bnRpbWVUYXNrU3RlcBIjCgVwZWVycxgCIAMoCzIULmF2aWtv",
            "bS5nZW5lcmljLlBlZXJCdQobYXBwLmF2aWtvbS50eXBlcy5hc3Npc3RhbmNl",
            "WjxnaXRsYWIudWIudW5pLWJpZWxlZmVsZC5kZS9hdmlrb20vZ28tdHlwZXMv",
            "YXZpa29tL2Fzc2lzdGFuY2WqAhdBdmlrb20uVHlwZXMuQXNzaXN0YW5jZWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Assistance.RuntimeTaskStepReflection.Descriptor, global::Avikom.Types.Generic.PeerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.RuntimeStepList), global::Avikom.Types.Assistance.RuntimeStepList.Parser, new[]{ "Steps", "Peers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A list of `RuntimeTaskSteps`. It also contains a list of `Peers` which can be used to conduct the passed steps.
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class RuntimeStepList : pb::IMessage<RuntimeStepList> {
    private static readonly pb::MessageParser<RuntimeStepList> _parser = new pb::MessageParser<RuntimeStepList>(() => new RuntimeStepList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RuntimeStepList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.RuntimeStepListReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RuntimeStepList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RuntimeStepList(RuntimeStepList other) : this() {
      steps_ = other.steps_.Clone();
      peers_ = other.peers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RuntimeStepList Clone() {
      return new RuntimeStepList(this);
    }

    /// <summary>Field number for the "steps" field.</summary>
    public const int StepsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Avikom.Types.Assistance.RuntimeTaskStep> _repeated_steps_codec
        = pb::FieldCodec.ForMessage(10, global::Avikom.Types.Assistance.RuntimeTaskStep.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep> steps_ = new pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep>();
    /// <summary>
    //// currently active task steps to be done 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep> Steps {
      get { return steps_; }
    }

    /// <summary>Field number for the "peers" field.</summary>
    public const int PeersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Avikom.Types.Generic.Peer> _repeated_peers_codec
        = pb::FieldCodec.ForMessage(18, global::Avikom.Types.Generic.Peer.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Generic.Peer> peers_ = new pbc::RepeatedField<global::Avikom.Types.Generic.Peer>();
    /// <summary>
    //// a list of peers that can be used to solve task steps
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Generic.Peer> Peers {
      get { return peers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RuntimeStepList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RuntimeStepList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!steps_.Equals(other.steps_)) return false;
      if(!peers_.Equals(other.peers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= steps_.GetHashCode();
      hash ^= peers_.GetHashCode();
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
      steps_.WriteTo(output, _repeated_steps_codec);
      peers_.WriteTo(output, _repeated_peers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += steps_.CalculateSize(_repeated_steps_codec);
      size += peers_.CalculateSize(_repeated_peers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RuntimeStepList other) {
      if (other == null) {
        return;
      }
      steps_.Add(other.steps_);
      peers_.Add(other.peers_);
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
            steps_.AddEntriesFrom(input, _repeated_steps_codec);
            break;
          }
          case 18: {
            peers_.AddEntriesFrom(input, _repeated_peers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
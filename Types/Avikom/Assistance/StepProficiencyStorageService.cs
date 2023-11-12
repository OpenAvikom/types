// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/step_proficiency_storage_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/step_proficiency_storage_service.proto</summary>
  public static partial class StepProficiencyStorageServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/step_proficiency_storage_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StepProficiencyStorageServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhhdmlrb20vYXNzaXN0YW5jZS9zdGVwX3Byb2ZpY2llbmN5X3N0b3JhZ2Vf",
            "c2VydmljZS5wcm90bxIRYXZpa29tLmFzc2lzdGFuY2UaKGF2aWtvbS9hc3Np",
            "c3RhbmNlL3N0ZXBfcHJvZmljaWVuY3kucHJvdG8aLmF2aWtvbS9hc3Npc3Rh",
            "bmNlL3NwbGl0X3Byb2NlZHVyZV9yZXN1bHQucHJvdG8aG2F2aWtvbS9nZW5l",
            "cmljL3Jlc3VsdC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byI8ChRTdGVwUHJvZmljaWVuY3lRdWVyeRIPCgd1c2VyX2lkGAEgASgNEhMK",
            "C3RhcmdldF9uYW1lGAIgASgJMvUECh1TdGVwUHJvZmljaWVuY3lTdG9yYWdl",
            "U2VydmljZRKmAQoSR2V0U3RlcFByb2ZpY2llbmN5EicuYXZpa29tLmFzc2lz",
            "dGFuY2UuU3RlcFByb2ZpY2llbmN5UXVlcnkaIi5hdmlrb20uYXNzaXN0YW5j",
            "ZS5TdGVwUHJvZmljaWVuY3kiQ4LT5JMCPRI7L3YxL3N0b3JhZ2Uvc3RlcF9w",
            "cm9maWNpZW5jaWVzL3N0ZXAve3RhcmdldF9uYW1lfS97dXNlcl9pZH0SewoS",
            "U2V0U3RlcFByb2ZpY2llbmN5EiIuYXZpa29tLmFzc2lzdGFuY2UuU3RlcFBy",
            "b2ZpY2llbmN5GhYuYXZpa29tLmdlbmVyaWMuUmVzdWx0IimC0+STAiMiHi92",
            "MS9zdG9yYWdlL3N0ZXBfcHJvZmljaWVuY2llczoBKhKoAQoXR2V0U3BsaXRQ",
            "cm9jZWR1cmVSZXN1bHQSJy5hdmlrb20uYXNzaXN0YW5jZS5TdGVwUHJvZmlj",
            "aWVuY3lRdWVyeRonLmF2aWtvbS5hc3Npc3RhbmNlLlNwbGl0UHJvY2VkdXJl",
            "UmVzdWx0IjuC0+STAjUSMy92MS9zdG9yYWdlL3NwbGl0X3Byb2NlZHVyZS97",
            "dGFyZ2V0X25hbWV9L3t1c2VyX2lkfRKCAQoXU2V0U3BsaXRQcm9jZWR1cmVS",
            "ZXN1bHQSJy5hdmlrb20uYXNzaXN0YW5jZS5TcGxpdFByb2NlZHVyZVJlc3Vs",
            "dBoWLmF2aWtvbS5nZW5lcmljLlJlc3VsdCImgtPkkwIgIhsvdjEvc3RvcmFn",
            "ZS9zcGxpdF9wcm9jZWR1cmU6ASpCdQobYXBwLmF2aWtvbS50eXBlcy5hc3Np",
            "c3RhbmNlWjxnaXRsYWIudWIudW5pLWJpZWxlZmVsZC5kZS9hdmlrb20vZ28t",
            "dHlwZXMvYXZpa29tL2Fzc2lzdGFuY2WqAhdBdmlrb20uVHlwZXMuQXNzaXN0",
            "YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Assistance.StepProficiencyReflection.Descriptor, global::Avikom.Types.Assistance.SplitProcedureResultReflection.Descriptor, global::Avikom.Types.Generic.ResultReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.StepProficiencyQuery), global::Avikom.Types.Assistance.StepProficiencyQuery.Parser, new[]{ "UserId", "TargetName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// A query to retrieve `StepProficiencies` for task steps or `SplitProcedureResults` for taks
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class StepProficiencyQuery : pb::IMessage<StepProficiencyQuery> {
    private static readonly pb::MessageParser<StepProficiencyQuery> _parser = new pb::MessageParser<StepProficiencyQuery>(() => new StepProficiencyQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StepProficiencyQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.StepProficiencyStorageServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepProficiencyQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepProficiencyQuery(StepProficiencyQuery other) : this() {
      userId_ = other.userId_;
      targetName_ = other.targetName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepProficiencyQuery Clone() {
      return new StepProficiencyQuery(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private uint userId_;
    /// <summary>
    //// ID of the user in question
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "target_name" field.</summary>
    public const int TargetNameFieldNumber = 2;
    private string targetName_ = "";
    /// <summary>
    //// either a task step name (for proficiencies) or a task name (for split procedure results)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetName {
      get { return targetName_; }
      set {
        targetName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StepProficiencyQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StepProficiencyQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (TargetName != other.TargetName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (TargetName.Length != 0) hash ^= TargetName.GetHashCode();
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
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UserId);
      }
      if (TargetName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserId);
      }
      if (TargetName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StepProficiencyQuery other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.TargetName.Length != 0) {
        TargetName = other.TargetName;
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
          case 8: {
            UserId = input.ReadUInt32();
            break;
          }
          case 18: {
            TargetName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/session.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/session.proto</summary>
  public static partial class SessionReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/session.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9hdmlrb20vYXNzaXN0YW5jZS9zZXNzaW9uLnByb3RvEhFhdmlrb20uYXNz",
            "aXN0YW5jZRocYXZpa29tL29wdGlvbnMvb3B0aW9ucy5wcm90bxodYXZpa29t",
            "L2Fzc2lzdGFuY2Uvc2NlbmUucHJvdG8aHGF2aWtvbS9hc3Npc3RhbmNlL3Rh",
            "c2sucHJvdG8aKWF2aWtvbS9hc3Npc3RhbmNlL3J1bnRpbWVfdGFza19zdGVw",
            "LnByb3RvGiJhdmlrb20vY2FtdW5kYS9leHRlcm5hbF90YXNrLnByb3RvGhlh",
            "dmlrb20vZ2VuZXJpYy9wZWVyLnByb3RvGiFhdmlrb20vZ2VuZXJpYy91c2Vy",
            "X3Byb2ZpbGUucHJvdG8aHWF2aWtvbS9nZW5lcmljL21vZGFsaXR5LnByb3Rv",
            "IsACCgdTZXNzaW9uEhIKAmlkGAEgASgJQgaKtRgCEAESJwoFc2NlbmUYAiAB",
            "KAsyGC5hdmlrb20uYXNzaXN0YW5jZS5TY2VuZRIjCgVwZWVycxgDIAMoCzIU",
            "LmF2aWtvbS5nZW5lcmljLlBlZXISMwoHY3VycmVudBgEIAMoCzIiLmF2aWtv",
            "bS5hc3Npc3RhbmNlLlJ1bnRpbWVUYXNrU3RlcBIsCgdwcm9maWxlGAUgASgL",
            "MhsuYXZpa29tLmdlbmVyaWMuVXNlclByb2ZpbGUSJQoEdGFzaxgGIAEoCzIX",
            "LmF2aWtvbS5hc3Npc3RhbmNlLlRhc2sSMAoObW9kYWxfYWZmaW5pdHkYByAB",
            "KAsyGC5hdmlrb20uZ2VuZXJpYy5Nb2RhbGl0eRIRCglqc29uX2RhdGEYCiAB",
            "KAk6BIi1GAFCdQobYXBwLmF2aWtvbS50eXBlcy5hc3Npc3RhbmNlWjxnaXRs",
            "YWIudWIudW5pLWJpZWxlZmVsZC5kZS9hdmlrb20vZ28tdHlwZXMvYXZpa29t",
            "L2Fzc2lzdGFuY2WqAhdBdmlrb20uVHlwZXMuQXNzaXN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Options.OptionsReflection.Descriptor, global::Avikom.Types.Assistance.SceneReflection.Descriptor, global::Avikom.Types.Assistance.TaskReflection.Descriptor, global::Avikom.Types.Assistance.RuntimeTaskStepReflection.Descriptor, global::Avikom.Types.Camunda.ExternalTaskReflection.Descriptor, global::Avikom.Types.Generic.PeerReflection.Descriptor, global::Avikom.Types.Generic.UserProfileReflection.Descriptor, global::Avikom.Types.Generic.ModalityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.Session), global::Avikom.Types.Assistance.Session.Parser, new[]{ "Id", "Scene", "Peers", "Current", "Profile", "Task", "ModalAffinity", "JsonData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// A (serializable) version of a session.
  /// Data should only be stored in json format if the represented data cannot be generalized.
  /// Note that sessions might contain temporal data that cannot be stored because of their short-times lifespan or due to serializiation limitations.
  /// For these cases, separate setup and tear down strategies should be considered.
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class Session : pb::IMessage<Session> {
    private static readonly pb::MessageParser<Session> _parser = new pb::MessageParser<Session>(() => new Session());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Session> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.SessionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session(Session other) : this() {
      id_ = other.id_;
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      peers_ = other.peers_.Clone();
      current_ = other.current_.Clone();
      profile_ = other.profile_ != null ? other.profile_.Clone() : null;
      task_ = other.task_ != null ? other.task_.Clone() : null;
      modalAffinity_ = other.modalAffinity_ != null ? other.modalAffinity_.Clone() : null;
      jsonData_ = other.jsonData_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session Clone() {
      return new Session(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    //// session ID; generated by `SessionService`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 2;
    private global::Avikom.Types.Assistance.Scene scene_;
    /// <summary>
    //// current scene; only the scene unique identifier (name) must be provided
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Assistance.Scene Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "peers" field.</summary>
    public const int PeersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Avikom.Types.Generic.Peer> _repeated_peers_codec
        = pb::FieldCodec.ForMessage(26, global::Avikom.Types.Generic.Peer.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Generic.Peer> peers_ = new pbc::RepeatedField<global::Avikom.Types.Generic.Peer>();
    /// <summary>
    //// a list of peers available in the session; only the unique identifier (name) must be provided
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Generic.Peer> Peers {
      get { return peers_; }
    }

    /// <summary>Field number for the "current" field.</summary>
    public const int CurrentFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Avikom.Types.Assistance.RuntimeTaskStep> _repeated_current_codec
        = pb::FieldCodec.ForMessage(34, global::Avikom.Types.Assistance.RuntimeTaskStep.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep> current_ = new pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep>();
    /// <summary>
    //// list of currently eligible `RuntimeTaskSteps`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Assistance.RuntimeTaskStep> Current {
      get { return current_; }
    }

    /// <summary>Field number for the "profile" field.</summary>
    public const int ProfileFieldNumber = 5;
    private global::Avikom.Types.Generic.UserProfile profile_;
    /// <summary>
    //// profile of the session's user
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Generic.UserProfile Profile {
      get { return profile_; }
      set {
        profile_ = value;
      }
    }

    /// <summary>Field number for the "task" field.</summary>
    public const int TaskFieldNumber = 6;
    private global::Avikom.Types.Assistance.Task task_;
    /// <summary>
    //// currently conducted task
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Assistance.Task Task {
      get { return task_; }
      set {
        task_ = value;
      }
    }

    /// <summary>Field number for the "modal_affinity" field.</summary>
    public const int ModalAffinityFieldNumber = 7;
    private global::Avikom.Types.Generic.Modality modalAffinity_;
    /// <summary>
    //// environmental factors of the session's context
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Generic.Modality ModalAffinity {
      get { return modalAffinity_; }
      set {
        modalAffinity_ = value;
      }
    }

    /// <summary>Field number for the "json_data" field.</summary>
    public const int JsonDataFieldNumber = 10;
    private string jsonData_ = "";
    /// <summary>
    //// used for session/task-specific data;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JsonData {
      get { return jsonData_; }
      set {
        jsonData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Session);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Session other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Scene, other.Scene)) return false;
      if(!peers_.Equals(other.peers_)) return false;
      if(!current_.Equals(other.current_)) return false;
      if (!object.Equals(Profile, other.Profile)) return false;
      if (!object.Equals(Task, other.Task)) return false;
      if (!object.Equals(ModalAffinity, other.ModalAffinity)) return false;
      if (JsonData != other.JsonData) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (scene_ != null) hash ^= Scene.GetHashCode();
      hash ^= peers_.GetHashCode();
      hash ^= current_.GetHashCode();
      if (profile_ != null) hash ^= Profile.GetHashCode();
      if (task_ != null) hash ^= Task.GetHashCode();
      if (modalAffinity_ != null) hash ^= ModalAffinity.GetHashCode();
      if (JsonData.Length != 0) hash ^= JsonData.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (scene_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Scene);
      }
      peers_.WriteTo(output, _repeated_peers_codec);
      current_.WriteTo(output, _repeated_current_codec);
      if (profile_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Profile);
      }
      if (task_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Task);
      }
      if (modalAffinity_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModalAffinity);
      }
      if (JsonData.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(JsonData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      size += peers_.CalculateSize(_repeated_peers_codec);
      size += current_.CalculateSize(_repeated_current_codec);
      if (profile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Profile);
      }
      if (task_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Task);
      }
      if (modalAffinity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModalAffinity);
      }
      if (JsonData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JsonData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Session other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::Avikom.Types.Assistance.Scene();
        }
        Scene.MergeFrom(other.Scene);
      }
      peers_.Add(other.peers_);
      current_.Add(other.current_);
      if (other.profile_ != null) {
        if (profile_ == null) {
          Profile = new global::Avikom.Types.Generic.UserProfile();
        }
        Profile.MergeFrom(other.Profile);
      }
      if (other.task_ != null) {
        if (task_ == null) {
          Task = new global::Avikom.Types.Assistance.Task();
        }
        Task.MergeFrom(other.Task);
      }
      if (other.modalAffinity_ != null) {
        if (modalAffinity_ == null) {
          ModalAffinity = new global::Avikom.Types.Generic.Modality();
        }
        ModalAffinity.MergeFrom(other.ModalAffinity);
      }
      if (other.JsonData.Length != 0) {
        JsonData = other.JsonData;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            if (scene_ == null) {
              Scene = new global::Avikom.Types.Assistance.Scene();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 26: {
            peers_.AddEntriesFrom(input, _repeated_peers_codec);
            break;
          }
          case 34: {
            current_.AddEntriesFrom(input, _repeated_current_codec);
            break;
          }
          case 42: {
            if (profile_ == null) {
              Profile = new global::Avikom.Types.Generic.UserProfile();
            }
            input.ReadMessage(Profile);
            break;
          }
          case 50: {
            if (task_ == null) {
              Task = new global::Avikom.Types.Assistance.Task();
            }
            input.ReadMessage(Task);
            break;
          }
          case 58: {
            if (modalAffinity_ == null) {
              ModalAffinity = new global::Avikom.Types.Generic.Modality();
            }
            input.ReadMessage(ModalAffinity);
            break;
          }
          case 82: {
            JsonData = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

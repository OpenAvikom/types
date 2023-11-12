// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/unity/scene_config_storage_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Unity {

  /// <summary>Holder for reflection information generated from avikom/unity/scene_config_storage_service.proto</summary>
  public static partial class SceneConfigStorageServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/unity/scene_config_storage_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneConfigStorageServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9hdmlrb20vdW5pdHkvc2NlbmVfY29uZmlnX3N0b3JhZ2Vfc2VydmljZS5w",
            "cm90bxIMYXZpa29tLnVuaXR5Ghthdmlrb20vZ2VuZXJpYy9yZXN1bHQucHJv",
            "dG8aH2F2aWtvbS91bml0eS9zY2VuZV9jb25maWcucHJvdG8aHmF2aWtvbS91",
            "bml0eS90YXNrX2NvbmZpZy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byImChBTY2VuZUNvbmZpZ1F1ZXJ5EhIKCnNjZW5lX25hbWUYASAB",
            "KAkiJAoPVGFza0NvbmZpZ1F1ZXJ5EhEKCXRhc2tfbmFtZRgBIAEoCTLUAwoZ",
            "U2NlbmVDb25maWdTdG9yYWdlU2VydmljZRJFCg5BZGRTY2VuZUNvbmZpZxIZ",
            "LmF2aWtvbS51bml0eS5TY2VuZUNvbmZpZxoWLmF2aWtvbS5nZW5lcmljLlJl",
            "c3VsdCIAEk0KDkdldFNjZW5lQ29uZmlnEh4uYXZpa29tLnVuaXR5LlNjZW5l",
            "Q29uZmlnUXVlcnkaGS5hdmlrb20udW5pdHkuU2NlbmVDb25maWciABJIChFV",
            "cGRhdGVTY2VuZUNvbmZpZxIZLmF2aWtvbS51bml0eS5TY2VuZUNvbmZpZxoW",
            "LmF2aWtvbS5nZW5lcmljLlJlc3VsdCIAEkMKDUFkZFRhc2tDb25maWcSGC5h",
            "dmlrb20udW5pdHkuVGFza0NvbmZpZxoWLmF2aWtvbS5nZW5lcmljLlJlc3Vs",
            "dCIAEkoKDUdldFRhc2tDb25maWcSHS5hdmlrb20udW5pdHkuVGFza0NvbmZp",
            "Z1F1ZXJ5GhguYXZpa29tLnVuaXR5LlRhc2tDb25maWciABJGChBVcGRhdGVU",
            "YXNrQ29uZmlnEhguYXZpa29tLnVuaXR5LlRhc2tDb25maWcaFi5hdmlrb20u",
            "Z2VuZXJpYy5SZXN1bHQiAEJmChZhcHAuYXZpa29tLnR5cGVzLnVuaXR5Wjdn",
            "aXRsYWIudWIudW5pLWJpZWxlZmVsZC5kZS9hdmlrb20vZ28tdHlwZXMvYXZp",
            "a29tL3VuaXR5qgISQXZpa29tLlR5cGVzLlVuaXR5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Generic.ResultReflection.Descriptor, global::Avikom.Types.Unity.SceneConfigReflection.Descriptor, global::Avikom.Types.Unity.TaskConfigReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Unity.SceneConfigQuery), global::Avikom.Types.Unity.SceneConfigQuery.Parser, new[]{ "SceneName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Unity.TaskConfigQuery), global::Avikom.Types.Unity.TaskConfigQuery.Parser, new[]{ "TaskName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A message to query a scene configuration by `scene_name`.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class SceneConfigQuery : pb::IMessage<SceneConfigQuery> {
    private static readonly pb::MessageParser<SceneConfigQuery> _parser = new pb::MessageParser<SceneConfigQuery>(() => new SceneConfigQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SceneConfigQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Unity.SceneConfigStorageServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneConfigQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneConfigQuery(SceneConfigQuery other) : this() {
      sceneName_ = other.sceneName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneConfigQuery Clone() {
      return new SceneConfigQuery(this);
    }

    /// <summary>Field number for the "scene_name" field.</summary>
    public const int SceneNameFieldNumber = 1;
    private string sceneName_ = "";
    /// <summary>
    //// name of the scene
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SceneName {
      get { return sceneName_; }
      set {
        sceneName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SceneConfigQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SceneConfigQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneName != other.SceneName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneName.Length != 0) hash ^= SceneName.GetHashCode();
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
      if (SceneName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SceneName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SceneName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SceneName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SceneConfigQuery other) {
      if (other == null) {
        return;
      }
      if (other.SceneName.Length != 0) {
        SceneName = other.SceneName;
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
            SceneName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///*
  /// A message to query a task configuration by `task_name`.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class TaskConfigQuery : pb::IMessage<TaskConfigQuery> {
    private static readonly pb::MessageParser<TaskConfigQuery> _parser = new pb::MessageParser<TaskConfigQuery>(() => new TaskConfigQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaskConfigQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Unity.SceneConfigStorageServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskConfigQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskConfigQuery(TaskConfigQuery other) : this() {
      taskName_ = other.taskName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskConfigQuery Clone() {
      return new TaskConfigQuery(this);
    }

    /// <summary>Field number for the "task_name" field.</summary>
    public const int TaskNameFieldNumber = 1;
    private string taskName_ = "";
    /// <summary>
    //// name of the task
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaskName {
      get { return taskName_; }
      set {
        taskName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaskConfigQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaskConfigQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TaskName != other.TaskName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TaskName.Length != 0) hash ^= TaskName.GetHashCode();
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
      if (TaskName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TaskName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TaskName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaskConfigQuery other) {
      if (other == null) {
        return;
      }
      if (other.TaskName.Length != 0) {
        TaskName = other.TaskName;
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
            TaskName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

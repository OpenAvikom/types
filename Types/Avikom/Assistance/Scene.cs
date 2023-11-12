// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/scene.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/scene.proto</summary>
  public static partial class SceneReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/scene.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1hdmlrb20vYXNzaXN0YW5jZS9zY2VuZS5wcm90bxIRYXZpa29tLmFzc2lz",
            "dGFuY2UaHGF2aWtvbS9vcHRpb25zL29wdGlvbnMucHJvdG8aHGF2aWtvbS9h",
            "c3Npc3RhbmNlL3Rhc2sucHJvdG8aHmF2aWtvbS91bml0eS9nYW1lX29iamVj",
            "dC5wcm90byJLCgVTY2VuZRIUCgRuYW1lGAEgASgJQgaKtRgCEAESJgoFdGFz",
            "a3MYAiADKAsyFy5hdmlrb20uYXNzaXN0YW5jZS5UYXNrOgSItRgBQnUKG2Fw",
            "cC5hdmlrb20udHlwZXMuYXNzaXN0YW5jZVo8Z2l0bGFiLnViLnVuaS1iaWVs",
            "ZWZlbGQuZGUvYXZpa29tL2dvLXR5cGVzL2F2aWtvbS9hc3Npc3RhbmNlqgIX",
            "QXZpa29tLlR5cGVzLkFzc2lzdGFuY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Options.OptionsReflection.Descriptor, global::Avikom.Types.Assistance.TaskReflection.Descriptor, global::Avikom.Types.Unity.GameObjectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.Scene), global::Avikom.Types.Assistance.Scene.Parser, new[]{ "Name", "Tasks" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// Describes the location/context of a task. This might be an office or a lab.
  /// The `tasks` field should only contain tasks that can be intialized without further information.
  /// For instance, when a task requires to be prepened by another task, it should be mentioned here.
  /// Thus, an `Issue` might contain a task that is not mentioned in `Session.tasks`.
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class Scene : pb::IMessage<Scene> {
    private static readonly pb::MessageParser<Scene> _parser = new pb::MessageParser<Scene>(() => new Scene());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Scene> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.SceneReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scene() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scene(Scene other) : this() {
      name_ = other.name_;
      tasks_ = other.tasks_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scene Clone() {
      return new Scene(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    //// a unique name for the location/context
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tasks" field.</summary>
    public const int TasksFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Avikom.Types.Assistance.Task> _repeated_tasks_codec
        = pb::FieldCodec.ForMessage(18, global::Avikom.Types.Assistance.Task.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Assistance.Task> tasks_ = new pbc::RepeatedField<global::Avikom.Types.Assistance.Task>();
    /// <summary>
    /// all the tasks that can be conducted without further information
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Assistance.Task> Tasks {
      get { return tasks_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Scene);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Scene other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!tasks_.Equals(other.tasks_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= tasks_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      tasks_.WriteTo(output, _repeated_tasks_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += tasks_.CalculateSize(_repeated_tasks_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Scene other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      tasks_.Add(other.tasks_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            tasks_.AddEntriesFrom(input, _repeated_tasks_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

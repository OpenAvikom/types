// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/instruction_media_value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/instruction_media_value.proto</summary>
  public static partial class InstructionMediaValueReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/instruction_media_value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstructionMediaValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9hdmlrb20vYXNzaXN0YW5jZS9pbnN0cnVjdGlvbl9tZWRpYV92YWx1ZS5w",
            "cm90bxIRYXZpa29tLmFzc2lzdGFuY2UijQEKFUluc3RydWN0aW9uTWVkaWFW",
            "YWx1ZRILCgN1cmkYASABKAkSCwoDdXJsGAIgASgJEgwKBGRhdGEYAyABKAwS",
            "KgoEdHlwZRgEIAEoDjIcLmF2aWtvbS5hc3Npc3RhbmNlLk1lZGlhVHlwZRIO",
            "CgZsb29wZWQYCiABKAgSEAoIYXV0b3BsYXkYCyABKAgq4gEKCU1lZGlhVHlw",
            "ZRIQCgxUWVBFX1VOS05PV04QABITCg9UWVBFX0lNQUdFX0pQRUcQARISCg5U",
            "WVBFX0lNQUdFX1BORxACEhIKDlRZUEVfVklERU9fTVA0EAUSEgoOVFlQRV9B",
            "VURJT19XQVYQChISCg5UWVBFX0FVRElPX01QMxALEhgKFFRZUEVfQVBQTElD",
            "QVRJT05fUERGEBQSGAoUVFlQRV9BUFBMSUNBVElPTl9YTUwQFRITCg9UWVBF",
            "X1RFWFRfUExBSU4QHhIVChFUWVBFX1dPUkxEX09CSkVDVBAoQnUKG2FwcC5h",
            "dmlrb20udHlwZXMuYXNzaXN0YW5jZVo8Z2l0bGFiLnViLnVuaS1iaWVsZWZl",
            "bGQuZGUvYXZpa29tL2dvLXR5cGVzL2F2aWtvbS9hc3Npc3RhbmNlqgIXQXZp",
            "a29tLlR5cGVzLkFzc2lzdGFuY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Avikom.Types.Assistance.MediaType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Assistance.InstructionMediaValue), global::Avikom.Types.Assistance.InstructionMediaValue.Parser, new[]{ "Uri", "Url", "Data", "Type", "Looped", "Autoplay" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///*
  /// Defines the (MIME) type of a media instruction.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public enum MediaType {
    [pbr::OriginalName("TYPE_UNKNOWN")] TypeUnknown = 0,
    [pbr::OriginalName("TYPE_IMAGE_JPEG")] TypeImageJpeg = 1,
    [pbr::OriginalName("TYPE_IMAGE_PNG")] TypeImagePng = 2,
    [pbr::OriginalName("TYPE_VIDEO_MP4")] TypeVideoMp4 = 5,
    [pbr::OriginalName("TYPE_AUDIO_WAV")] TypeAudioWav = 10,
    [pbr::OriginalName("TYPE_AUDIO_MP3")] TypeAudioMp3 = 11,
    [pbr::OriginalName("TYPE_APPLICATION_PDF")] TypeApplicationPdf = 20,
    [pbr::OriginalName("TYPE_APPLICATION_XML")] TypeApplicationXml = 21,
    [pbr::OriginalName("TYPE_TEXT_PLAIN")] TypeTextPlain = 30,
    [pbr::OriginalName("TYPE_WORLD_OBJECT")] TypeWorldObject = 40,
  }

  #endregion

  #region Messages
  /// <summary>
  ///*
  /// The actual value of a media instruction. Only one field should be set.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class InstructionMediaValue : pb::IMessage<InstructionMediaValue> {
    private static readonly pb::MessageParser<InstructionMediaValue> _parser = new pb::MessageParser<InstructionMediaValue>(() => new InstructionMediaValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InstructionMediaValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Assistance.InstructionMediaValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstructionMediaValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstructionMediaValue(InstructionMediaValue other) : this() {
      uri_ = other.uri_;
      url_ = other.url_;
      data_ = other.data_;
      type_ = other.type_;
      looped_ = other.looped_;
      autoplay_ = other.autoplay_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstructionMediaValue Clone() {
      return new InstructionMediaValue(this);
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 1;
    private string uri_ = "";
    /// <summary>
    //// a local ressource identifier; resolution is receiver-specific
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    /// <summary>
    //// a global reference to a ressource; should be taken literally
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 3;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    //// the media file as a data stream
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Avikom.Types.Assistance.MediaType type_ = 0;
    /// <summary>
    //// type hint for this media value
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Assistance.MediaType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "looped" field.</summary>
    public const int LoopedFieldNumber = 10;
    private bool looped_;
    /// <summary>
    //// determines whether a media file should be looped (if playable)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Looped {
      get { return looped_; }
      set {
        looped_ = value;
      }
    }

    /// <summary>Field number for the "autoplay" field.</summary>
    public const int AutoplayFieldNumber = 11;
    private bool autoplay_;
    /// <summary>
    //// determines whether a media file should be opened/executed right away
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Autoplay {
      get { return autoplay_; }
      set {
        autoplay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InstructionMediaValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InstructionMediaValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uri != other.Uri) return false;
      if (Url != other.Url) return false;
      if (Data != other.Data) return false;
      if (Type != other.Type) return false;
      if (Looped != other.Looped) return false;
      if (Autoplay != other.Autoplay) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Looped != false) hash ^= Looped.GetHashCode();
      if (Autoplay != false) hash ^= Autoplay.GetHashCode();
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
      if (Uri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Data);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Looped != false) {
        output.WriteRawTag(80);
        output.WriteBool(Looped);
      }
      if (Autoplay != false) {
        output.WriteRawTag(88);
        output.WriteBool(Autoplay);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Looped != false) {
        size += 1 + 1;
      }
      if (Autoplay != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InstructionMediaValue other) {
      if (other == null) {
        return;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Looped != false) {
        Looped = other.Looped;
      }
      if (other.Autoplay != false) {
        Autoplay = other.Autoplay;
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
            Uri = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            Data = input.ReadBytes();
            break;
          }
          case 32: {
            Type = (global::Avikom.Types.Assistance.MediaType) input.ReadEnum();
            break;
          }
          case 80: {
            Looped = input.ReadBool();
            break;
          }
          case 88: {
            Autoplay = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
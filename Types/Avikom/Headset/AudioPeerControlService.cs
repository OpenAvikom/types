// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/headset/audio_peer_control_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Headset {

  /// <summary>Holder for reflection information generated from avikom/headset/audio_peer_control_service.proto</summary>
  public static partial class AudioPeerControlServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/headset/audio_peer_control_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudioPeerControlServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9hdmlrb20vaGVhZHNldC9hdWRpb19wZWVyX2NvbnRyb2xfc2VydmljZS5w",
            "cm90bxIOYXZpa29tLmhlYWRzZXQaG2F2aWtvbS9nZW5lcmljL3Jlc3VsdC5w",
            "cm90bxolYXZpa29tL2hlYWRzZXQvZnVuY3Rpb25hbF9zb3VuZC5wcm90bxol",
            "YXZpa29tL2hlYWRzZXQvY29tbW9uX3V0dGVyYW5jZS5wcm90bxobZ29vZ2xl",
            "L3Byb3RvYnVmL2VtcHR5LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25z",
            "LnByb3RvIjoKFEF1ZGlvUGVlck1vZGVSZXF1ZXN0EiIKBG1vZGUYAiABKA4y",
            "FC5hdmlrb20uaGVhZHNldC5Nb2RlImgKFkZ1bmN0aW9uYWxTb3VuZFJlcXVl",
            "c3QSOQoQZnVuY3Rpb25hbF9zb3VuZBgCIAEoDjIfLmF2aWtvbS5oZWFkc2V0",
            "LkZ1bmN0aW9uYWxTb3VuZBITCgtvdGhlcl9zb3VuZBgDIAEoCSJaCgpTYXlS",
            "ZXF1ZXN0EhEKCXV0dGVyYW5jZRgCIAEoCRI5ChBjb21tb25fdXR0ZXJhbmNl",
            "GAMgASgOMh8uYXZpa29tLmhlYWRzZXQuQ29tbW9uVXR0ZXJhbmNlKkAKBE1v",
            "ZGUSEAoMTU9ERV9VTktOT1dOEAASEAoMTU9ERV9ERUZBVUxUEAESFAoQTU9E",
            "RV9UUkFOU1BBUkVOVBACMvABChdBdWRpb1BlZXJDb250cm9sU2VydmljZRJJ",
            "CgdTZXRNb2RlEiQuYXZpa29tLmhlYWRzZXQuQXVkaW9QZWVyTW9kZVJlcXVl",
            "c3QaFi5hdmlrb20uZ2VuZXJpYy5SZXN1bHQiABJNCglQbGF5U291bmQSJi5h",
            "dmlrb20uaGVhZHNldC5GdW5jdGlvbmFsU291bmRSZXF1ZXN0GhYuYXZpa29t",
            "LmdlbmVyaWMuUmVzdWx0IgASOwoDU2F5EhouYXZpa29tLmhlYWRzZXQuU2F5",
            "UmVxdWVzdBoWLmF2aWtvbS5nZW5lcmljLlJlc3VsdCIAQmwKGGFwcC5hdmlr",
            "b20udHlwZXMuaGVhZHNldFo5Z2l0bGFiLnViLnVuaS1iaWVsZWZlbGQuZGUv",
            "YXZpa29tL2dvLXR5cGVzL2F2aWtvbS9oZWFkc2V0qgIUQXZpa29tLlR5cGVz",
            "LkhlYWRzZXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Generic.ResultReflection.Descriptor, global::Avikom.Types.Headset.FunctionalSoundReflection.Descriptor, global::Avikom.Types.Headset.CommonUtteranceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Avikom.Types.Headset.Mode), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Headset.AudioPeerModeRequest), global::Avikom.Types.Headset.AudioPeerModeRequest.Parser, new[]{ "Mode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Headset.FunctionalSoundRequest), global::Avikom.Types.Headset.FunctionalSoundRequest.Parser, new[]{ "FunctionalSound", "OtherSound" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Headset.SayRequest), global::Avikom.Types.Headset.SayRequest.Parser, new[]{ "Utterance", "CommonUtterance" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///*
  /// Defines the mode that should be activated for the auditory peer. The mode changes the auditory input and output 
  /// behaviour of the auditory peer.
  /// @author: Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public enum Mode {
    /// <summary>
    //// represents an unset mode; should not be used actively
    /// </summary>
    [pbr::OriginalName("MODE_UNKNOWN")] Unknown = 0,
    /// <summary>
    //// resets the auditory peer to plain input-output mode
    /// </summary>
    [pbr::OriginalName("MODE_DEFAULT")] Default = 1,
    /// <summary>
    //// sound picked up be the microphone is played back via the headphones
    /// </summary>
    [pbr::OriginalName("MODE_TRANSPARENT")] Transparent = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  ///*
  /// A Mode request passed to SetMode.
  /// @author: Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public sealed partial class AudioPeerModeRequest : pb::IMessage<AudioPeerModeRequest> {
    private static readonly pb::MessageParser<AudioPeerModeRequest> _parser = new pb::MessageParser<AudioPeerModeRequest>(() => new AudioPeerModeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AudioPeerModeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Headset.AudioPeerControlServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPeerModeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPeerModeRequest(AudioPeerModeRequest other) : this() {
      mode_ = other.mode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPeerModeRequest Clone() {
      return new AudioPeerModeRequest(this);
    }

    /// <summary>Field number for the "mode" field.</summary>
    public const int ModeFieldNumber = 2;
    private global::Avikom.Types.Headset.Mode mode_ = 0;
    /// <summary>
    //// the mode the auditory peer should activate
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Headset.Mode Mode {
      get { return mode_; }
      set {
        mode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AudioPeerModeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AudioPeerModeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mode != other.Mode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mode != 0) hash ^= Mode.GetHashCode();
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
      if (Mode != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Mode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AudioPeerModeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Mode != 0) {
        Mode = other.Mode;
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
          case 16: {
            Mode = (global::Avikom.Types.Headset.Mode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///*
  /// A FunctionalSound request that either includes a standardized functional sound or the name of 
  /// an audio file to be played. The audio file has to be available in the web-client data path "data/Default/Sounds".
  /// @author: Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public sealed partial class FunctionalSoundRequest : pb::IMessage<FunctionalSoundRequest> {
    private static readonly pb::MessageParser<FunctionalSoundRequest> _parser = new pb::MessageParser<FunctionalSoundRequest>(() => new FunctionalSoundRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FunctionalSoundRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Headset.AudioPeerControlServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionalSoundRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionalSoundRequest(FunctionalSoundRequest other) : this() {
      functionalSound_ = other.functionalSound_;
      otherSound_ = other.otherSound_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionalSoundRequest Clone() {
      return new FunctionalSoundRequest(this);
    }

    /// <summary>Field number for the "functional_sound" field.</summary>
    public const int FunctionalSoundFieldNumber = 2;
    private global::Avikom.Types.Headset.FunctionalSound functionalSound_ = 0;
    /// <summary>
    //// a set of predefined sounds to provide feedback to users
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Headset.FunctionalSound FunctionalSound {
      get { return functionalSound_; }
      set {
        functionalSound_ = value;
      }
    }

    /// <summary>Field number for the "other_sound" field.</summary>
    public const int OtherSoundFieldNumber = 3;
    private string otherSound_ = "";
    /// <summary>
    //// 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OtherSound {
      get { return otherSound_; }
      set {
        otherSound_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FunctionalSoundRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FunctionalSoundRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FunctionalSound != other.FunctionalSound) return false;
      if (OtherSound != other.OtherSound) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FunctionalSound != 0) hash ^= FunctionalSound.GetHashCode();
      if (OtherSound.Length != 0) hash ^= OtherSound.GetHashCode();
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
      if (FunctionalSound != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FunctionalSound);
      }
      if (OtherSound.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OtherSound);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FunctionalSound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FunctionalSound);
      }
      if (OtherSound.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OtherSound);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FunctionalSoundRequest other) {
      if (other == null) {
        return;
      }
      if (other.FunctionalSound != 0) {
        FunctionalSound = other.FunctionalSound;
      }
      if (other.OtherSound.Length != 0) {
        OtherSound = other.OtherSound;
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
          case 16: {
            FunctionalSound = (global::Avikom.Types.Headset.FunctionalSound) input.ReadEnum();
            break;
          }
          case 26: {
            OtherSound = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///*
  /// A request that either includes a standardized utterance or custom output to be played back via TTS. 
  /// The output is queued with other speech output.
  /// @author: Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public sealed partial class SayRequest : pb::IMessage<SayRequest> {
    private static readonly pb::MessageParser<SayRequest> _parser = new pb::MessageParser<SayRequest>(() => new SayRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SayRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Headset.AudioPeerControlServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SayRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SayRequest(SayRequest other) : this() {
      utterance_ = other.utterance_;
      commonUtterance_ = other.commonUtterance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SayRequest Clone() {
      return new SayRequest(this);
    }

    /// <summary>Field number for the "utterance" field.</summary>
    public const int UtteranceFieldNumber = 2;
    private string utterance_ = "";
    /// <summary>
    //// a string representation of what should be generated as speech
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Utterance {
      get { return utterance_; }
      set {
        utterance_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "common_utterance" field.</summary>
    public const int CommonUtteranceFieldNumber = 3;
    private global::Avikom.Types.Headset.CommonUtterance commonUtterance_ = 0;
    /// <summary>
    //// a set of predefined speech outputs
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Avikom.Types.Headset.CommonUtterance CommonUtterance {
      get { return commonUtterance_; }
      set {
        commonUtterance_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SayRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SayRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Utterance != other.Utterance) return false;
      if (CommonUtterance != other.CommonUtterance) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Utterance.Length != 0) hash ^= Utterance.GetHashCode();
      if (CommonUtterance != 0) hash ^= CommonUtterance.GetHashCode();
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
      if (Utterance.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Utterance);
      }
      if (CommonUtterance != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CommonUtterance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Utterance.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Utterance);
      }
      if (CommonUtterance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CommonUtterance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SayRequest other) {
      if (other == null) {
        return;
      }
      if (other.Utterance.Length != 0) {
        Utterance = other.Utterance;
      }
      if (other.CommonUtterance != 0) {
        CommonUtterance = other.CommonUtterance;
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
          case 18: {
            Utterance = input.ReadString();
            break;
          }
          case 24: {
            CommonUtterance = (global::Avikom.Types.Headset.CommonUtterance) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/math/float_matrix.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Math {

  /// <summary>Holder for reflection information generated from avikom/math/float_matrix.proto</summary>
  public static partial class FloatMatrixReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/math/float_matrix.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FloatMatrixReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5hdmlrb20vbWF0aC9mbG9hdF9tYXRyaXgucHJvdG8SC2F2aWtvbS5tYXRo",
            "Gh1hdmlrb20vbWF0aC9mbG9hdF9hcnJheS5wcm90byI0CgtGbG9hdE1hdHJp",
            "eBIlCgRyb3dzGAEgAygLMhcuYXZpa29tLm1hdGguRmxvYXRBcnJheUJjChVh",
            "cHAuYXZpa29tLnR5cGVzLm1hdGhaNmdpdGxhYi51Yi51bmktYmllbGVmZWxk",
            "LmRlL2F2aWtvbS9nby10eXBlcy9hdmlrb20vbWF0aKoCEUF2aWtvbS5UeXBl",
            "cy5NYXRoYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Avikom.Types.Math.FloatArrayReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Avikom.Types.Math.FloatMatrix), global::Avikom.Types.Math.FloatMatrix.Parser, new[]{ "Rows" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  ///An list of `FloatArrays` meant to store matrices.
  ///@author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public sealed partial class FloatMatrix : pb::IMessage<FloatMatrix> {
    private static readonly pb::MessageParser<FloatMatrix> _parser = new pb::MessageParser<FloatMatrix>(() => new FloatMatrix());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FloatMatrix> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Avikom.Types.Math.FloatMatrixReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatMatrix() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatMatrix(FloatMatrix other) : this() {
      rows_ = other.rows_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatMatrix Clone() {
      return new FloatMatrix(this);
    }

    /// <summary>Field number for the "rows" field.</summary>
    public const int RowsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Avikom.Types.Math.FloatArray> _repeated_rows_codec
        = pb::FieldCodec.ForMessage(10, global::Avikom.Types.Math.FloatArray.Parser);
    private readonly pbc::RepeatedField<global::Avikom.Types.Math.FloatArray> rows_ = new pbc::RepeatedField<global::Avikom.Types.Math.FloatArray>();
    /// <summary>
    //// list of `FloatArrays`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Avikom.Types.Math.FloatArray> Rows {
      get { return rows_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FloatMatrix);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FloatMatrix other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rows_.Equals(other.rows_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rows_.GetHashCode();
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
      rows_.WriteTo(output, _repeated_rows_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += rows_.CalculateSize(_repeated_rows_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FloatMatrix other) {
      if (other == null) {
        return;
      }
      rows_.Add(other.rows_);
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
            rows_.AddEntriesFrom(input, _repeated_rows_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

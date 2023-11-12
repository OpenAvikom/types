// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/assistance_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Assistance {

  /// <summary>Holder for reflection information generated from avikom/assistance/assistance_level.proto</summary>
  public static partial class AssistanceLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/assistance/assistance_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssistanceLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihhdmlrb20vYXNzaXN0YW5jZS9hc3Npc3RhbmNlX2xldmVsLnByb3RvEhFh",
            "dmlrb20uYXNzaXN0YW5jZSpNCg9Bc3Npc3RhbmNlTGV2ZWwSCwoHVU5LTk9X",
            "ThAAEggKBE5PTkUQARIJCgVCUklFRhACEgsKB0RFRkFVTFQQBRILCgdWRVJC",
            "T1NFEAlCdQobYXBwLmF2aWtvbS50eXBlcy5hc3Npc3RhbmNlWjxnaXRsYWIu",
            "dWIudW5pLWJpZWxlZmVsZC5kZS9hdmlrb20vZ28tdHlwZXMvYXZpa29tL2Fz",
            "c2lzdGFuY2WqAhdBdmlrb20uVHlwZXMuQXNzaXN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Avikom.Types.Assistance.AssistanceLevel), }, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///*
  /// This enum describes the assistance level required by a user or assigned to an instruction.
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public enum AssistanceLevel {
    /// <summary>
    //// representes an unset level; should not be used explicitely
    /// </summary>
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    /// <summary>
    //// user requires no assistance; instructions assigned to this level are considered mandatory
    /// </summary>
    [pbr::OriginalName("NONE")] None = 1,
    /// <summary>
    //// provides some (textual/visual) hooks to remember the step at hand
    /// </summary>
    [pbr::OriginalName("BRIEF")] Brief = 2,
    /// <summary>
    //// this should be the experience for new and unknown users
    /// </summary>
    [pbr::OriginalName("DEFAULT")] Default = 5,
    /// <summary>
    //// highest demand for assistance; should provide all assistance possible
    /// </summary>
    [pbr::OriginalName("VERBOSE")] Verbose = 9,
  }

  #endregion

}

#endregion Designer generated code
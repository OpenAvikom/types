// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/headset/functional_sound.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Avikom.Types.Headset {

  /// <summary>Holder for reflection information generated from avikom/headset/functional_sound.proto</summary>
  public static partial class FunctionalSoundReflection {

    #region Descriptor
    /// <summary>File descriptor for avikom/headset/functional_sound.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FunctionalSoundReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVhdmlrb20vaGVhZHNldC9mdW5jdGlvbmFsX3NvdW5kLnByb3RvEg5hdmlr",
            "b20uaGVhZHNldCqFAwoPRnVuY3Rpb25hbFNvdW5kEhEKDVNPVU5EX0RFRkFV",
            "TFQQABISCg5TT1VORF9HVUlEQU5DRRABEhoKFlNPVU5EX0lOU1RSVUNUSU9O",
            "X0lORk8QAhIbChdTT1VORF9JTlNUUlVDVElPTl9BTEVSVBADEhsKF1NPVU5E",
            "X0lOU1RSVUNUSU9OX0FMQVJNEAQSDwoLU09VTkRfRVJST1IQBRIYChRTT1VO",
            "RF9UQVNLX0NPTVBMRVRFRBAGEh4KGlNPVU5EX1NZU1RFTV9QUk9HUkVTU19X",
            "QUlUEAcSHgoaU09VTkRfTkVYVF9TVEVQX0lOX0JST1dTRVIQCBIiCh5TT1VO",
            "RF9QUkVWSU9VU19TVEVQX0lOX0JST1dTRVIQCRIVChFTT1VORF9CVVRUT05f",
            "RE9XThAKEhMKD1NPVU5EX0JVVFRPTl9VUBALEg0KCVNPVU5EX1RBUBAMEhUK",
            "EVNPVU5EX0dSQVNQX1NUQVJUEA0SFAoQU09VTkRfR1JBU1BfU1RPUBAOQmwK",
            "GGFwcC5hdmlrb20udHlwZXMuaGVhZHNldFo5Z2l0bGFiLnViLnVuaS1iaWVs",
            "ZWZlbGQuZGUvYXZpa29tL2dvLXR5cGVzL2F2aWtvbS9oZWFkc2V0qgIUQXZp",
            "a29tLlR5cGVzLkhlYWRzZXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Avikom.Types.Headset.FunctionalSound), }, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///*
  /// This enum describes common functional sounds that can be played back on an auditory peer
  /// to provide feedback to a user.
  /// @author: Lars Schalkwijk &lt;lars.schalkwijk@fh-bielefeld.de>
  /// </summary>
  public enum FunctionalSound {
    /// <summary>
    //// generates no output
    /// </summary>
    [pbr::OriginalName("SOUND_DEFAULT")] SoundDefault = 0,
    /// <summary>
    //// should be used when trying to guide the user to specific location
    /// </summary>
    [pbr::OriginalName("SOUND_GUIDANCE")] SoundGuidance = 1,
    /// <summary>
    //// should be used for instructions with ContentStyle "INFO"
    /// </summary>
    [pbr::OriginalName("SOUND_INSTRUCTION_INFO")] SoundInstructionInfo = 2,
    /// <summary>
    //// should be used for instructions with ContentStyle "WARNING"
    /// </summary>
    [pbr::OriginalName("SOUND_INSTRUCTION_ALERT")] SoundInstructionAlert = 3,
    /// <summary>
    //// should be used for instructions with ContentStyle "CRITICAL"
    /// </summary>
    [pbr::OriginalName("SOUND_INSTRUCTION_ALARM")] SoundInstructionAlarm = 4,
    /// <summary>
    //// should be used when notifying a user that an error occured
    /// </summary>
    [pbr::OriginalName("SOUND_ERROR")] SoundError = 5,
    /// <summary>
    //// should be used for providing positive feedback in key moments (i.e. on completion of a task)
    /// </summary>
    [pbr::OriginalName("SOUND_TASK_COMPLETED")] SoundTaskCompleted = 6,
    /// <summary>
    //// should be used to notify user that the system is processing user input 
    /// </summary>
    [pbr::OriginalName("SOUND_SYSTEM_PROGRESS_WAIT")] SoundSystemProgressWait = 7,
    /// <summary>
    //// should be used when next step is shown in step browser 
    /// </summary>
    [pbr::OriginalName("SOUND_NEXT_STEP_IN_BROWSER")] SoundNextStepInBrowser = 8,
    /// <summary>
    //// should be used when previous step is shown in step browser
    /// </summary>
    [pbr::OriginalName("SOUND_PREVIOUS_STEP_IN_BROWSER")] SoundPreviousStepInBrowser = 9,
    /// <summary>
    //// should be used when user presses a button
    /// </summary>
    [pbr::OriginalName("SOUND_BUTTON_DOWN")] SoundButtonDown = 10,
    /// <summary>
    //// shuold be used when user lifts button press
    /// </summary>
    [pbr::OriginalName("SOUND_BUTTON_UP")] SoundButtonUp = 11,
    /// <summary>
    //// should be used when user taps
    /// </summary>
    [pbr::OriginalName("SOUND_TAP")] SoundTap = 12,
    /// <summary>
    //// should be used when user grasps a virtual object 
    /// </summary>
    [pbr::OriginalName("SOUND_GRASP_START")] SoundGraspStart = 13,
    /// <summary>
    //// should be used when user releases a a virtual object
    /// </summary>
    [pbr::OriginalName("SOUND_GRASP_STOP")] SoundGraspStop = 14,
  }

  #endregion

}

#endregion Designer generated code
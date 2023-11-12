// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/tracking/gaze_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Avikom.Types.Tracking {
  /// <summary>
  ///*
  /// A service that provides the current gaze target of a user.
  /// It's up to the caller to determine the correct service peer for the desired user.
  /// @author: Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public static partial class GazeService
  {
    static readonly string __ServiceName = "avikom.tracking.GazeService";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Avikom.Types.Tracking.GazeTarget> __Marshaller_avikom_tracking_GazeTarget = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Tracking.GazeTarget.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Avikom.Types.Tracking.GazeTarget> __Method_FocusedObject = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Avikom.Types.Tracking.GazeTarget>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "FocusedObject",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_avikom_tracking_GazeTarget);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Avikom.Types.Tracking.GazeServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GazeService</summary>
    [grpc::BindServiceMethod(typeof(GazeService), "BindService")]
    public abstract partial class GazeServiceBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task FocusedObject(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::Avikom.Types.Tracking.GazeTarget> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GazeService</summary>
    public partial class GazeServiceClient : grpc::ClientBase<GazeServiceClient>
    {
      /// <summary>Creates a new client for GazeService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GazeServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GazeService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GazeServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GazeServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GazeServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Avikom.Types.Tracking.GazeTarget> FocusedObject(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FocusedObject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Avikom.Types.Tracking.GazeTarget> FocusedObject(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_FocusedObject, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GazeServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GazeServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GazeServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FocusedObject, serviceImpl.FocusedObject).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GazeServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FocusedObject, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Avikom.Types.Tracking.GazeTarget>(serviceImpl.FocusedObject));
    }

  }
}
#endregion
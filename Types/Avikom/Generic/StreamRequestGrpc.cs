// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/generic/stream_request.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Avikom.Types.Generic {
  /// <summary>
  ///*
  /// 
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public static partial class StreamRequestService
  {
    static readonly string __ServiceName = "avikom.generic.StreamRequestService";

    static readonly grpc::Marshaller<global::Avikom.Types.Generic.StreamRequest> __Marshaller_avikom_generic_StreamRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Generic.StreamRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Avikom.Types.Generic.Peer> __Marshaller_avikom_generic_Peer = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Generic.Peer.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Avikom.Types.Generic.StreamRequest, global::Avikom.Types.Generic.Peer> __Method_InitStream = new grpc::Method<global::Avikom.Types.Generic.StreamRequest, global::Avikom.Types.Generic.Peer>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InitStream",
        __Marshaller_avikom_generic_StreamRequest,
        __Marshaller_avikom_generic_Peer);

    static readonly grpc::Method<global::Avikom.Types.Generic.StreamRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CloseStream = new grpc::Method<global::Avikom.Types.Generic.StreamRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CloseStream",
        __Marshaller_avikom_generic_StreamRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Avikom.Types.Generic.StreamRequestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StreamRequestService</summary>
    [grpc::BindServiceMethod(typeof(StreamRequestService), "BindService")]
    public abstract partial class StreamRequestServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Avikom.Types.Generic.Peer> InitStream(global::Avikom.Types.Generic.StreamRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CloseStream(global::Avikom.Types.Generic.StreamRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StreamRequestService</summary>
    public partial class StreamRequestServiceClient : grpc::ClientBase<StreamRequestServiceClient>
    {
      /// <summary>Creates a new client for StreamRequestService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StreamRequestServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StreamRequestService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StreamRequestServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StreamRequestServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StreamRequestServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Avikom.Types.Generic.Peer InitStream(global::Avikom.Types.Generic.StreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Avikom.Types.Generic.Peer InitStream(global::Avikom.Types.Generic.StreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InitStream, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Peer> InitStreamAsync(global::Avikom.Types.Generic.StreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitStreamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Peer> InitStreamAsync(global::Avikom.Types.Generic.StreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InitStream, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CloseStream(global::Avikom.Types.Generic.StreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CloseStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CloseStream(global::Avikom.Types.Generic.StreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CloseStream, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CloseStreamAsync(global::Avikom.Types.Generic.StreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CloseStreamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CloseStreamAsync(global::Avikom.Types.Generic.StreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CloseStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StreamRequestServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StreamRequestServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StreamRequestServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InitStream, serviceImpl.InitStream)
          .AddMethod(__Method_CloseStream, serviceImpl.CloseStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StreamRequestServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InitStream, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Generic.StreamRequest, global::Avikom.Types.Generic.Peer>(serviceImpl.InitStream));
      serviceBinder.AddMethod(__Method_CloseStream, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Generic.StreamRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CloseStream));
    }

  }
}
#endregion

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: avikom/assistance/issue_storage_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Avikom.Types.Assistance {
  /// <summary>
  ///*
  /// A database service to create, update and delete issues.
  /// @author Alexander Neumann &lt;alneuman@techfak.uni-bielefeld.de>
  /// </summary>
  public static partial class IssueStorageService
  {
    static readonly string __ServiceName = "avikom.assistance.IssueStorageService";

    static readonly grpc::Marshaller<global::Avikom.Types.Assistance.IssueQuery> __Marshaller_avikom_assistance_IssueQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Assistance.IssueQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Avikom.Types.Assistance.IssueList> __Marshaller_avikom_assistance_IssueList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Assistance.IssueList.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Avikom.Types.Assistance.Issue> __Marshaller_avikom_assistance_Issue = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Assistance.Issue.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Avikom.Types.Generic.Result> __Marshaller_avikom_generic_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Avikom.Types.Generic.Result.Parser.ParseFrom);

    static readonly grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Assistance.IssueList> __Method_GetIssue = new grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Assistance.IssueList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIssue",
        __Marshaller_avikom_assistance_IssueQuery,
        __Marshaller_avikom_assistance_IssueList);

    static readonly grpc::Method<global::Avikom.Types.Assistance.Issue, global::Avikom.Types.Generic.Result> __Method_CreateIssue = new grpc::Method<global::Avikom.Types.Assistance.Issue, global::Avikom.Types.Generic.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateIssue",
        __Marshaller_avikom_assistance_Issue,
        __Marshaller_avikom_generic_Result);

    static readonly grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result> __Method_UpdateIssueStatus = new grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateIssueStatus",
        __Marshaller_avikom_assistance_IssueQuery,
        __Marshaller_avikom_generic_Result);

    static readonly grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result> __Method_DeleteIssue = new grpc::Method<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteIssue",
        __Marshaller_avikom_assistance_IssueQuery,
        __Marshaller_avikom_generic_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Avikom.Types.Assistance.IssueStorageServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IssueStorageService</summary>
    [grpc::BindServiceMethod(typeof(IssueStorageService), "BindService")]
    public abstract partial class IssueStorageServiceBase
    {
      /// <summary>
      //// Returns a list of issues filtered by `IssueQuery`
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Avikom.Types.Assistance.IssueList> GetIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      //// Creates a new issue; Issue.id must be set by the caller!
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Avikom.Types.Generic.Result> CreateIssue(global::Avikom.Types.Assistance.Issue request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      //// Updates an exisiting issue. IssueQuery must contain an id and a new status.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Avikom.Types.Generic.Result> UpdateIssueStatus(global::Avikom.Types.Assistance.IssueQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      //// Deletes an issue. IssueQuery.id must be set!
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Avikom.Types.Generic.Result> DeleteIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IssueStorageService</summary>
    public partial class IssueStorageServiceClient : grpc::ClientBase<IssueStorageServiceClient>
    {
      /// <summary>Creates a new client for IssueStorageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IssueStorageServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IssueStorageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IssueStorageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IssueStorageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IssueStorageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      //// Returns a list of issues filtered by `IssueQuery`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Assistance.IssueList GetIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIssue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Returns a list of issues filtered by `IssueQuery`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Assistance.IssueList GetIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIssue, null, options, request);
      }
      /// <summary>
      //// Returns a list of issues filtered by `IssueQuery`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Assistance.IssueList> GetIssueAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIssueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Returns a list of issues filtered by `IssueQuery`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Assistance.IssueList> GetIssueAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIssue, null, options, request);
      }
      /// <summary>
      //// Creates a new issue; Issue.id must be set by the caller!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result CreateIssue(global::Avikom.Types.Assistance.Issue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIssue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Creates a new issue; Issue.id must be set by the caller!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result CreateIssue(global::Avikom.Types.Assistance.Issue request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateIssue, null, options, request);
      }
      /// <summary>
      //// Creates a new issue; Issue.id must be set by the caller!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> CreateIssueAsync(global::Avikom.Types.Assistance.Issue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIssueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Creates a new issue; Issue.id must be set by the caller!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> CreateIssueAsync(global::Avikom.Types.Assistance.Issue request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateIssue, null, options, request);
      }
      /// <summary>
      //// Updates an exisiting issue. IssueQuery must contain an id and a new status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result UpdateIssueStatus(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIssueStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Updates an exisiting issue. IssueQuery must contain an id and a new status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result UpdateIssueStatus(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateIssueStatus, null, options, request);
      }
      /// <summary>
      //// Updates an exisiting issue. IssueQuery must contain an id and a new status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> UpdateIssueStatusAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIssueStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Updates an exisiting issue. IssueQuery must contain an id and a new status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> UpdateIssueStatusAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateIssueStatus, null, options, request);
      }
      /// <summary>
      //// Deletes an issue. IssueQuery.id must be set!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result DeleteIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIssue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Deletes an issue. IssueQuery.id must be set!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Avikom.Types.Generic.Result DeleteIssue(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteIssue, null, options, request);
      }
      /// <summary>
      //// Deletes an issue. IssueQuery.id must be set!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> DeleteIssueAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIssueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      //// Deletes an issue. IssueQuery.id must be set!
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Avikom.Types.Generic.Result> DeleteIssueAsync(global::Avikom.Types.Assistance.IssueQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteIssue, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IssueStorageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IssueStorageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IssueStorageServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetIssue, serviceImpl.GetIssue)
          .AddMethod(__Method_CreateIssue, serviceImpl.CreateIssue)
          .AddMethod(__Method_UpdateIssueStatus, serviceImpl.UpdateIssueStatus)
          .AddMethod(__Method_DeleteIssue, serviceImpl.DeleteIssue).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, IssueStorageServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetIssue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Assistance.IssueList>(serviceImpl.GetIssue));
      serviceBinder.AddMethod(__Method_CreateIssue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Assistance.Issue, global::Avikom.Types.Generic.Result>(serviceImpl.CreateIssue));
      serviceBinder.AddMethod(__Method_UpdateIssueStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result>(serviceImpl.UpdateIssueStatus));
      serviceBinder.AddMethod(__Method_DeleteIssue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Avikom.Types.Assistance.IssueQuery, global::Avikom.Types.Generic.Result>(serviceImpl.DeleteIssue));
    }

  }
}
#endregion

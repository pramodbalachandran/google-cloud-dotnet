// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/bigquery/storage/v1/storage.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.BigQuery.Storage.V1 {
  /// <summary>
  /// BigQuery Read API.
  ///
  /// The Read API can be used to read data from BigQuery.
  /// </summary>
  public static partial class BigQueryRead
  {
    static readonly string __ServiceName = "google.cloud.bigquery.storage.v1.BigQueryRead";

    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest> __Marshaller_google_cloud_bigquery_storage_v1_CreateReadSessionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.ReadSession> __Marshaller_google_cloud_bigquery_storage_v1_ReadSession = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.ReadSession.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest> __Marshaller_google_cloud_bigquery_storage_v1_ReadRowsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse> __Marshaller_google_cloud_bigquery_storage_v1_ReadRowsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest> __Marshaller_google_cloud_bigquery_storage_v1_SplitReadStreamRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse> __Marshaller_google_cloud_bigquery_storage_v1_SplitReadStreamResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadSession> __Method_CreateReadSession = new grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadSession>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateReadSession",
        __Marshaller_google_cloud_bigquery_storage_v1_CreateReadSessionRequest,
        __Marshaller_google_cloud_bigquery_storage_v1_ReadSession);

    static readonly grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse> __Method_ReadRows = new grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ReadRows",
        __Marshaller_google_cloud_bigquery_storage_v1_ReadRowsRequest,
        __Marshaller_google_cloud_bigquery_storage_v1_ReadRowsResponse);

    static readonly grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest, global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse> __Method_SplitReadStream = new grpc::Method<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest, global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SplitReadStream",
        __Marshaller_google_cloud_bigquery_storage_v1_SplitReadStreamRequest,
        __Marshaller_google_cloud_bigquery_storage_v1_SplitReadStreamResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.BigQuery.Storage.V1.StorageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BigQueryRead</summary>
    [grpc::BindServiceMethod(typeof(BigQueryRead), "BindService")]
    public abstract partial class BigQueryReadBase
    {
      /// <summary>
      /// Creates a new read session. A read session divides the contents of a
      /// BigQuery table into one or more streams, which can then be used to read
      /// data from the table. The read session also specifies properties of the
      /// data to be read, such as a list of columns or a push-down filter describing
      /// the rows to be returned.
      ///
      /// A particular row can be read by at most one stream. When the caller has
      /// reached the end of each stream in the session, then all the data in the
      /// table has been read.
      ///
      /// Data is assigned to each stream such that roughly the same number of
      /// rows can be read from each stream. Because the server-side unit for
      /// assigning data is collections of rows, the API does not guarantee that
      /// each stream will return the same number or rows. Additionally, the
      /// limits are enforced based on the number of pre-filtered rows, so some
      /// filters can lead to lopsided assignments.
      ///
      /// Read sessions automatically expire 24 hours after they are created and do
      /// not require manual clean-up by the caller.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.BigQuery.Storage.V1.ReadSession> CreateReadSession(global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Reads rows from the stream in the format prescribed by the ReadSession.
      /// Each response contains one or more table rows, up to a maximum of 100 MiB
      /// per response; read requests which attempt to read individual rows larger
      /// than 100 MiB will fail.
      ///
      /// Each request also returns a set of stream statistics reflecting the current
      /// state of the stream.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task ReadRows(global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest request, grpc::IServerStreamWriter<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Splits a given `ReadStream` into two `ReadStream` objects. These
      /// `ReadStream` objects are referred to as the primary and the residual
      /// streams of the split. The original `ReadStream` can still be read from in
      /// the same manner as before. Both of the returned `ReadStream` objects can
      /// also be read from, and the rows returned by both child streams will be
      /// the same as the rows read from the original stream.
      ///
      /// Moreover, the two child streams will be allocated back-to-back in the
      /// original `ReadStream`. Concretely, it is guaranteed that for streams
      /// original, primary, and residual, that original[0-j] = primary[0-j] and
      /// original[j-n] = residual[0-m] once the streams have been read to
      /// completion.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse> SplitReadStream(global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BigQueryRead</summary>
    public partial class BigQueryReadClient : grpc::ClientBase<BigQueryReadClient>
    {
      /// <summary>Creates a new client for BigQueryRead</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BigQueryReadClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BigQueryRead that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BigQueryReadClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BigQueryReadClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BigQueryReadClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a new read session. A read session divides the contents of a
      /// BigQuery table into one or more streams, which can then be used to read
      /// data from the table. The read session also specifies properties of the
      /// data to be read, such as a list of columns or a push-down filter describing
      /// the rows to be returned.
      ///
      /// A particular row can be read by at most one stream. When the caller has
      /// reached the end of each stream in the session, then all the data in the
      /// table has been read.
      ///
      /// Data is assigned to each stream such that roughly the same number of
      /// rows can be read from each stream. Because the server-side unit for
      /// assigning data is collections of rows, the API does not guarantee that
      /// each stream will return the same number or rows. Additionally, the
      /// limits are enforced based on the number of pre-filtered rows, so some
      /// filters can lead to lopsided assignments.
      ///
      /// Read sessions automatically expire 24 hours after they are created and do
      /// not require manual clean-up by the caller.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.BigQuery.Storage.V1.ReadSession CreateReadSession(global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReadSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new read session. A read session divides the contents of a
      /// BigQuery table into one or more streams, which can then be used to read
      /// data from the table. The read session also specifies properties of the
      /// data to be read, such as a list of columns or a push-down filter describing
      /// the rows to be returned.
      ///
      /// A particular row can be read by at most one stream. When the caller has
      /// reached the end of each stream in the session, then all the data in the
      /// table has been read.
      ///
      /// Data is assigned to each stream such that roughly the same number of
      /// rows can be read from each stream. Because the server-side unit for
      /// assigning data is collections of rows, the API does not guarantee that
      /// each stream will return the same number or rows. Additionally, the
      /// limits are enforced based on the number of pre-filtered rows, so some
      /// filters can lead to lopsided assignments.
      ///
      /// Read sessions automatically expire 24 hours after they are created and do
      /// not require manual clean-up by the caller.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.BigQuery.Storage.V1.ReadSession CreateReadSession(global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateReadSession, null, options, request);
      }
      /// <summary>
      /// Creates a new read session. A read session divides the contents of a
      /// BigQuery table into one or more streams, which can then be used to read
      /// data from the table. The read session also specifies properties of the
      /// data to be read, such as a list of columns or a push-down filter describing
      /// the rows to be returned.
      ///
      /// A particular row can be read by at most one stream. When the caller has
      /// reached the end of each stream in the session, then all the data in the
      /// table has been read.
      ///
      /// Data is assigned to each stream such that roughly the same number of
      /// rows can be read from each stream. Because the server-side unit for
      /// assigning data is collections of rows, the API does not guarantee that
      /// each stream will return the same number or rows. Additionally, the
      /// limits are enforced based on the number of pre-filtered rows, so some
      /// filters can lead to lopsided assignments.
      ///
      /// Read sessions automatically expire 24 hours after they are created and do
      /// not require manual clean-up by the caller.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BigQuery.Storage.V1.ReadSession> CreateReadSessionAsync(global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReadSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new read session. A read session divides the contents of a
      /// BigQuery table into one or more streams, which can then be used to read
      /// data from the table. The read session also specifies properties of the
      /// data to be read, such as a list of columns or a push-down filter describing
      /// the rows to be returned.
      ///
      /// A particular row can be read by at most one stream. When the caller has
      /// reached the end of each stream in the session, then all the data in the
      /// table has been read.
      ///
      /// Data is assigned to each stream such that roughly the same number of
      /// rows can be read from each stream. Because the server-side unit for
      /// assigning data is collections of rows, the API does not guarantee that
      /// each stream will return the same number or rows. Additionally, the
      /// limits are enforced based on the number of pre-filtered rows, so some
      /// filters can lead to lopsided assignments.
      ///
      /// Read sessions automatically expire 24 hours after they are created and do
      /// not require manual clean-up by the caller.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BigQuery.Storage.V1.ReadSession> CreateReadSessionAsync(global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateReadSession, null, options, request);
      }
      /// <summary>
      /// Reads rows from the stream in the format prescribed by the ReadSession.
      /// Each response contains one or more table rows, up to a maximum of 100 MiB
      /// per response; read requests which attempt to read individual rows larger
      /// than 100 MiB will fail.
      ///
      /// Each request also returns a set of stream statistics reflecting the current
      /// state of the stream.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse> ReadRows(global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadRows(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads rows from the stream in the format prescribed by the ReadSession.
      /// Each response contains one or more table rows, up to a maximum of 100 MiB
      /// per response; read requests which attempt to read individual rows larger
      /// than 100 MiB will fail.
      ///
      /// Each request also returns a set of stream statistics reflecting the current
      /// state of the stream.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse> ReadRows(global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ReadRows, null, options, request);
      }
      /// <summary>
      /// Splits a given `ReadStream` into two `ReadStream` objects. These
      /// `ReadStream` objects are referred to as the primary and the residual
      /// streams of the split. The original `ReadStream` can still be read from in
      /// the same manner as before. Both of the returned `ReadStream` objects can
      /// also be read from, and the rows returned by both child streams will be
      /// the same as the rows read from the original stream.
      ///
      /// Moreover, the two child streams will be allocated back-to-back in the
      /// original `ReadStream`. Concretely, it is guaranteed that for streams
      /// original, primary, and residual, that original[0-j] = primary[0-j] and
      /// original[j-n] = residual[0-m] once the streams have been read to
      /// completion.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse SplitReadStream(global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SplitReadStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Splits a given `ReadStream` into two `ReadStream` objects. These
      /// `ReadStream` objects are referred to as the primary and the residual
      /// streams of the split. The original `ReadStream` can still be read from in
      /// the same manner as before. Both of the returned `ReadStream` objects can
      /// also be read from, and the rows returned by both child streams will be
      /// the same as the rows read from the original stream.
      ///
      /// Moreover, the two child streams will be allocated back-to-back in the
      /// original `ReadStream`. Concretely, it is guaranteed that for streams
      /// original, primary, and residual, that original[0-j] = primary[0-j] and
      /// original[j-n] = residual[0-m] once the streams have been read to
      /// completion.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse SplitReadStream(global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SplitReadStream, null, options, request);
      }
      /// <summary>
      /// Splits a given `ReadStream` into two `ReadStream` objects. These
      /// `ReadStream` objects are referred to as the primary and the residual
      /// streams of the split. The original `ReadStream` can still be read from in
      /// the same manner as before. Both of the returned `ReadStream` objects can
      /// also be read from, and the rows returned by both child streams will be
      /// the same as the rows read from the original stream.
      ///
      /// Moreover, the two child streams will be allocated back-to-back in the
      /// original `ReadStream`. Concretely, it is guaranteed that for streams
      /// original, primary, and residual, that original[0-j] = primary[0-j] and
      /// original[j-n] = residual[0-m] once the streams have been read to
      /// completion.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse> SplitReadStreamAsync(global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SplitReadStreamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Splits a given `ReadStream` into two `ReadStream` objects. These
      /// `ReadStream` objects are referred to as the primary and the residual
      /// streams of the split. The original `ReadStream` can still be read from in
      /// the same manner as before. Both of the returned `ReadStream` objects can
      /// also be read from, and the rows returned by both child streams will be
      /// the same as the rows read from the original stream.
      ///
      /// Moreover, the two child streams will be allocated back-to-back in the
      /// original `ReadStream`. Concretely, it is guaranteed that for streams
      /// original, primary, and residual, that original[0-j] = primary[0-j] and
      /// original[j-n] = residual[0-m] once the streams have been read to
      /// completion.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse> SplitReadStreamAsync(global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SplitReadStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BigQueryReadClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BigQueryReadClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BigQueryReadBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateReadSession, serviceImpl.CreateReadSession)
          .AddMethod(__Method_ReadRows, serviceImpl.ReadRows)
          .AddMethod(__Method_SplitReadStream, serviceImpl.SplitReadStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BigQueryReadBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateReadSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BigQuery.Storage.V1.CreateReadSessionRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadSession>(serviceImpl.CreateReadSession));
      serviceBinder.AddMethod(__Method_ReadRows, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Cloud.BigQuery.Storage.V1.ReadRowsRequest, global::Google.Cloud.BigQuery.Storage.V1.ReadRowsResponse>(serviceImpl.ReadRows));
      serviceBinder.AddMethod(__Method_SplitReadStream, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamRequest, global::Google.Cloud.BigQuery.Storage.V1.SplitReadStreamResponse>(serviceImpl.SplitReadStream));
    }

  }
}
#endregion
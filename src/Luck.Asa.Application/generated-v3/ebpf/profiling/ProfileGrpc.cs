// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ebpf/profiling/Profile.proto
// </auto-generated>
// Original file comments:
//
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements.  See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License.  You may obtain a copy of the License at
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
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Skywalking.V3 {
  /// <summary>
  /// Define the Rover Process profiling task and upload profiling data.
  /// </summary>
  public static partial class EBPFProfilingService
  {
    static readonly string __ServiceName = "skywalking.v3.EBPFProfilingService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Skywalking.V3.EBPFProfilingTaskQuery> __Marshaller_skywalking_v3_EBPFProfilingTaskQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Skywalking.V3.EBPFProfilingTaskQuery.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.Commands> __Marshaller_skywalking_v3_Commands = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.Commands.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Skywalking.V3.EBPFProfilingData> __Marshaller_skywalking_v3_EBPFProfilingData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Skywalking.V3.EBPFProfilingData.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Skywalking.V3.EBPFProfilingTaskQuery, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_queryTasks = new grpc::Method<global::Skywalking.V3.EBPFProfilingTaskQuery, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "queryTasks",
        __Marshaller_skywalking_v3_EBPFProfilingTaskQuery,
        __Marshaller_skywalking_v3_Commands);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Skywalking.V3.EBPFProfilingData, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_collectProfilingData = new grpc::Method<global::Skywalking.V3.EBPFProfilingData, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "collectProfilingData",
        __Marshaller_skywalking_v3_EBPFProfilingData,
        __Marshaller_skywalking_v3_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Skywalking.V3.ProfileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EBPFProfilingService</summary>
    [grpc::BindServiceMethod(typeof(EBPFProfilingService), "BindService")]
    public abstract partial class EBPFProfilingServiceBase
    {
      /// <summary>
      /// Query profiling (start or stop) tasks
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> queryTasks(global::Skywalking.V3.EBPFProfilingTaskQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// collect profiling data
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> collectProfilingData(grpc::IAsyncStreamReader<global::Skywalking.V3.EBPFProfilingData> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(EBPFProfilingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_queryTasks, serviceImpl.queryTasks)
          .AddMethod(__Method_collectProfilingData, serviceImpl.collectProfilingData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EBPFProfilingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_queryTasks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Skywalking.V3.EBPFProfilingTaskQuery, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.queryTasks));
      serviceBinder.AddMethod(__Method_collectProfilingData, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Skywalking.V3.EBPFProfilingData, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.collectProfilingData));
    }

  }
}
#endregion

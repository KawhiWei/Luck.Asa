// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service-mesh-probe/service-mesh.proto
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

namespace SkyWalking.NetworkProtocol.V3 {
  /// <summary>
  /// Define metrics report service. The metrics format is typically representing the data model collected in the service mesh case.
  /// </summary>
  public static partial class ServiceMeshMetricService
  {
    static readonly string __ServiceName = "skywalking.v3.ServiceMeshMetricService";

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
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics> __Marshaller_skywalking_v3_ServiceMeshMetrics = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream> __Marshaller_skywalking_v3_MeshProbeDownstream = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics, global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream> __Method_collect = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics, global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "collect",
        __Marshaller_skywalking_v3_ServiceMeshMetrics,
        __Marshaller_skywalking_v3_MeshProbeDownstream);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.V3.ServiceMeshReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServiceMeshMetricService</summary>
    [grpc::BindServiceMethod(typeof(ServiceMeshMetricService), "BindService")]
    public abstract partial class ServiceMeshMetricServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream> collect(grpc::IAsyncStreamReader<global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServiceMeshMetricServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_collect, serviceImpl.collect).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceMeshMetricServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_collect, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::SkyWalking.NetworkProtocol.V3.ServiceMeshMetrics, global::SkyWalking.NetworkProtocol.V3.MeshProbeDownstream>(serviceImpl.collect));
    }

  }
}
#endregion

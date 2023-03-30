// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ebpf/profiling/Process.proto
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
  /// Define the detected processes and report them.
  /// </summary>
  public static partial class EBPFProcessService
  {
    static readonly string __ServiceName = "skywalking.v3.EBPFProcessService";

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
    static readonly grpc::Marshaller<global::Skywalking.V3.EBPFProcessReportList> __Marshaller_skywalking_v3_EBPFProcessReportList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Skywalking.V3.EBPFProcessReportList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Skywalking.V3.EBPFReportProcessDownstream> __Marshaller_skywalking_v3_EBPFReportProcessDownstream = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Skywalking.V3.EBPFReportProcessDownstream.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Skywalking.V3.EBPFProcessPingPkgList> __Marshaller_skywalking_v3_EBPFProcessPingPkgList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Skywalking.V3.EBPFProcessPingPkgList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.Commands> __Marshaller_skywalking_v3_Commands = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.Commands.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Skywalking.V3.EBPFProcessReportList, global::Skywalking.V3.EBPFReportProcessDownstream> __Method_reportProcesses = new grpc::Method<global::Skywalking.V3.EBPFProcessReportList, global::Skywalking.V3.EBPFReportProcessDownstream>(
        grpc::MethodType.Unary,
        __ServiceName,
        "reportProcesses",
        __Marshaller_skywalking_v3_EBPFProcessReportList,
        __Marshaller_skywalking_v3_EBPFReportProcessDownstream);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Skywalking.V3.EBPFProcessPingPkgList, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_keepAlive = new grpc::Method<global::Skywalking.V3.EBPFProcessPingPkgList, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "keepAlive",
        __Marshaller_skywalking_v3_EBPFProcessPingPkgList,
        __Marshaller_skywalking_v3_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Skywalking.V3.ProcessReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EBPFProcessService</summary>
    [grpc::BindServiceMethod(typeof(EBPFProcessService), "BindService")]
    public abstract partial class EBPFProcessServiceBase
    {
      /// <summary>
      /// Report discovered process in Rover
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Skywalking.V3.EBPFReportProcessDownstream> reportProcesses(global::Skywalking.V3.EBPFProcessReportList request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Keep the process alive in the backend.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> keepAlive(global::Skywalking.V3.EBPFProcessPingPkgList request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(EBPFProcessServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_reportProcesses, serviceImpl.reportProcesses)
          .AddMethod(__Method_keepAlive, serviceImpl.keepAlive).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EBPFProcessServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_reportProcesses, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Skywalking.V3.EBPFProcessReportList, global::Skywalking.V3.EBPFReportProcessDownstream>(serviceImpl.reportProcesses));
      serviceBinder.AddMethod(__Method_keepAlive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Skywalking.V3.EBPFProcessPingPkgList, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.keepAlive));
    }

  }
}
#endregion
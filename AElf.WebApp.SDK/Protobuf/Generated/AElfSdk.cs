// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AElf.WebApp.SDK/Protobuf/Proto/AElfSdk.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElfSdk {

  /// <summary>Holder for reflection information generated from AElf.WebApp.SDK/Protobuf/Proto/AElfSdk.proto</summary>
  public static partial class AElfSdkReflection {

    #region Descriptor
    /// <summary>File descriptor for AElf.WebApp.SDK/Protobuf/Proto/AElfSdk.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AElfSdkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixBRWxmLldlYkFwcC5TREsvUHJvdG9idWYvUHJvdG8vQUVsZlNkay5wcm90",
            "byIhChFGaWxlRGVzY3JpcHRvclNldBIMCgRmaWxlGAEgAygMQgqqAgdBRWxm",
            "U2RrYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElfSdk.FileDescriptorSet), global::AElfSdk.FileDescriptorSet.Parser, new[]{ "File" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FileDescriptorSet : pb::IMessage<FileDescriptorSet> {
    private static readonly pb::MessageParser<FileDescriptorSet> _parser = new pb::MessageParser<FileDescriptorSet>(() => new FileDescriptorSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FileDescriptorSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElfSdk.AElfSdkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileDescriptorSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileDescriptorSet(FileDescriptorSet other) : this() {
      file_ = other.file_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileDescriptorSet Clone() {
      return new FileDescriptorSet(this);
    }

    /// <summary>Field number for the "file" field.</summary>
    public const int FileFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_file_codec
        = pb::FieldCodec.ForBytes(10);
    private readonly pbc::RepeatedField<pb::ByteString> file_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> File {
      get { return file_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FileDescriptorSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FileDescriptorSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!file_.Equals(other.file_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= file_.GetHashCode();
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
      file_.WriteTo(output, _repeated_file_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += file_.CalculateSize(_repeated_file_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FileDescriptorSet other) {
      if (other == null) {
        return;
      }
      file_.Add(other.file_);
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
            file_.AddEntriesFrom(input, _repeated_file_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

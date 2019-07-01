// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/framework/variable.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/variable.proto</summary>
  public static partial class VariableReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/variable.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VariableReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3ZhcmlhYmxlLnByb3RvEgp0",
            "ZW5zb3JmbG93IsgCCgtWYXJpYWJsZURlZhIVCg12YXJpYWJsZV9uYW1lGAEg",
            "ASgJEhoKEmluaXRpYWxfdmFsdWVfbmFtZRgGIAEoCRIYChBpbml0aWFsaXpl",
            "cl9uYW1lGAIgASgJEhUKDXNuYXBzaG90X25hbWUYAyABKAkSOQoTc2F2ZV9z",
            "bGljZV9pbmZvX2RlZhgEIAEoCzIcLnRlbnNvcmZsb3cuU2F2ZVNsaWNlSW5m",
            "b0RlZhITCgtpc19yZXNvdXJjZRgFIAEoCBIRCgl0cmFpbmFibGUYByABKAgS",
            "PAoPc3luY2hyb25pemF0aW9uGAggASgOMiMudGVuc29yZmxvdy5WYXJpYWJs",
            "ZVN5bmNocm9uaXphdGlvbhI0CgthZ2dyZWdhdGlvbhgJIAEoDjIfLnRlbnNv",
            "cmZsb3cuVmFyaWFibGVBZ2dyZWdhdGlvbiJgChBTYXZlU2xpY2VJbmZvRGVm",
            "EhEKCWZ1bGxfbmFtZRgBIAEoCRISCgpmdWxsX3NoYXBlGAIgAygDEhIKCnZh",
            "cl9vZmZzZXQYAyADKAMSEQoJdmFyX3NoYXBlGAQgAygDKqwBChdWYXJpYWJs",
            "ZVN5bmNocm9uaXphdGlvbhIhCh1WQVJJQUJMRV9TWU5DSFJPTklaQVRJT05f",
            "QVVUTxAAEiEKHVZBUklBQkxFX1NZTkNIUk9OSVpBVElPTl9OT05FEAESJQoh",
            "VkFSSUFCTEVfU1lOQ0hST05JWkFUSU9OX09OX1dSSVRFEAISJAogVkFSSUFC",
            "TEVfU1lOQ0hST05JWkFUSU9OX09OX1JFQUQQAyqeAQoTVmFyaWFibGVBZ2dy",
            "ZWdhdGlvbhIdChlWQVJJQUJMRV9BR0dSRUdBVElPTl9OT05FEAASHAoYVkFS",
            "SUFCTEVfQUdHUkVHQVRJT05fU1VNEAESHQoZVkFSSUFCTEVfQUdHUkVHQVRJ",
            "T05fTUVBThACEisKJ1ZBUklBQkxFX0FHR1JFR0FUSU9OX09OTFlfRklSU1Rf",
            "UkVQTElDQRADQi8KGG9yZy50ZW5zb3JmbG93LmZyYW1ld29ya0IOVmFyaWFi",
            "bGVQcm90b3NQAfgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Tensorflow.VariableSynchronization), typeof(global::Tensorflow.VariableAggregation), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.VariableDef), global::Tensorflow.VariableDef.Parser, new[]{ "VariableName", "InitialValueName", "InitializerName", "SnapshotName", "SaveSliceInfoDef", "IsResource", "Trainable", "Synchronization", "Aggregation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.SaveSliceInfoDef), global::Tensorflow.SaveSliceInfoDef.Parser, new[]{ "FullName", "FullShape", "VarOffset", "VarShape" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Indicates when a distributed variable will be synced.
  /// </summary>
  public enum VariableSynchronization {
    /// <summary>
    /// `AUTO`: Indicates that the synchronization will be determined by the
    /// current `DistributionStrategy` (eg. With `MirroredStrategy` this would be
    /// `ON_WRITE`).
    /// </summary>
    [pbr::OriginalName("VARIABLE_SYNCHRONIZATION_AUTO")] Auto = 0,
    /// <summary>
    /// `NONE`: Indicates that there will only be one copy of the variable, so
    /// there is no need to sync.
    /// </summary>
    [pbr::OriginalName("VARIABLE_SYNCHRONIZATION_NONE")] None = 1,
    /// <summary>
    /// `ON_WRITE`: Indicates that the variable will be updated across devices
    /// every time it is written.
    /// </summary>
    [pbr::OriginalName("VARIABLE_SYNCHRONIZATION_ON_WRITE")] OnWrite = 2,
    /// <summary>
    /// `ON_READ`: Indicates that the variable will be aggregated across devices
    /// when it is read (eg. when checkpointing or when evaluating an op that uses
    /// the variable).
    /// </summary>
    [pbr::OriginalName("VARIABLE_SYNCHRONIZATION_ON_READ")] OnRead = 3,
  }

  /// <summary>
  /// Indicates how a distributed variable will be aggregated.
  /// </summary>
  public enum VariableAggregation {
    /// <summary>
    /// `NONE`: This is the default, giving an error if you use a
    /// variable-update operation with multiple replicas.
    /// </summary>
    [pbr::OriginalName("VARIABLE_AGGREGATION_NONE")] None = 0,
    /// <summary>
    /// `SUM`: Add the updates across replicas.
    /// </summary>
    [pbr::OriginalName("VARIABLE_AGGREGATION_SUM")] Sum = 1,
    /// <summary>
    /// `MEAN`: Take the arithmetic mean ("average") of the updates across
    /// replicas.
    /// </summary>
    [pbr::OriginalName("VARIABLE_AGGREGATION_MEAN")] Mean = 2,
    /// <summary>
    /// `ONLY_FIRST_REPLICA`: This is for when every replica is performing the same
    /// update, but we only want to perform the update once. Used, e.g., for the
    /// global step counter.
    /// </summary>
    [pbr::OriginalName("VARIABLE_AGGREGATION_ONLY_FIRST_REPLICA")] OnlyFirstReplica = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Protocol buffer representing a Variable.
  /// </summary>
  public sealed partial class VariableDef : pb::IMessage<VariableDef> {
    private static readonly pb::MessageParser<VariableDef> _parser = new pb::MessageParser<VariableDef>(() => new VariableDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VariableDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.VariableReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VariableDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VariableDef(VariableDef other) : this() {
      variableName_ = other.variableName_;
      initialValueName_ = other.initialValueName_;
      initializerName_ = other.initializerName_;
      snapshotName_ = other.snapshotName_;
      saveSliceInfoDef_ = other.saveSliceInfoDef_ != null ? other.saveSliceInfoDef_.Clone() : null;
      isResource_ = other.isResource_;
      trainable_ = other.trainable_;
      synchronization_ = other.synchronization_;
      aggregation_ = other.aggregation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VariableDef Clone() {
      return new VariableDef(this);
    }

    /// <summary>Field number for the "variable_name" field.</summary>
    public const int VariableNameFieldNumber = 1;
    private string variableName_ = "";
    /// <summary>
    /// Name of the variable tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VariableName {
      get { return variableName_; }
      set {
        variableName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "initial_value_name" field.</summary>
    public const int InitialValueNameFieldNumber = 6;
    private string initialValueName_ = "";
    /// <summary>
    /// Name of the tensor holding the variable's initial value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InitialValueName {
      get { return initialValueName_; }
      set {
        initialValueName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "initializer_name" field.</summary>
    public const int InitializerNameFieldNumber = 2;
    private string initializerName_ = "";
    /// <summary>
    /// Name of the initializer op.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InitializerName {
      get { return initializerName_; }
      set {
        initializerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "snapshot_name" field.</summary>
    public const int SnapshotNameFieldNumber = 3;
    private string snapshotName_ = "";
    /// <summary>
    /// Name of the snapshot tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SnapshotName {
      get { return snapshotName_; }
      set {
        snapshotName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "save_slice_info_def" field.</summary>
    public const int SaveSliceInfoDefFieldNumber = 4;
    private global::Tensorflow.SaveSliceInfoDef saveSliceInfoDef_;
    /// <summary>
    /// Support for saving variables as slices of a larger variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.SaveSliceInfoDef SaveSliceInfoDef {
      get { return saveSliceInfoDef_; }
      set {
        saveSliceInfoDef_ = value;
      }
    }

    /// <summary>Field number for the "is_resource" field.</summary>
    public const int IsResourceFieldNumber = 5;
    private bool isResource_;
    /// <summary>
    /// Whether to represent this as a ResourceVariable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsResource {
      get { return isResource_; }
      set {
        isResource_ = value;
      }
    }

    /// <summary>Field number for the "trainable" field.</summary>
    public const int TrainableFieldNumber = 7;
    private bool trainable_;
    /// <summary>
    /// Whether this variable should be trained.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Trainable {
      get { return trainable_; }
      set {
        trainable_ = value;
      }
    }

    /// <summary>Field number for the "synchronization" field.</summary>
    public const int SynchronizationFieldNumber = 8;
    private global::Tensorflow.VariableSynchronization synchronization_ = 0;
    /// <summary>
    /// Indicates when a distributed variable will be synced.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.VariableSynchronization Synchronization {
      get { return synchronization_; }
      set {
        synchronization_ = value;
      }
    }

    /// <summary>Field number for the "aggregation" field.</summary>
    public const int AggregationFieldNumber = 9;
    private global::Tensorflow.VariableAggregation aggregation_ = 0;
    /// <summary>
    /// Indicates how a distributed variable will be aggregated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.VariableAggregation Aggregation {
      get { return aggregation_; }
      set {
        aggregation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VariableDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VariableDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VariableName != other.VariableName) return false;
      if (InitialValueName != other.InitialValueName) return false;
      if (InitializerName != other.InitializerName) return false;
      if (SnapshotName != other.SnapshotName) return false;
      if (!object.Equals(SaveSliceInfoDef, other.SaveSliceInfoDef)) return false;
      if (IsResource != other.IsResource) return false;
      if (Trainable != other.Trainable) return false;
      if (Synchronization != other.Synchronization) return false;
      if (Aggregation != other.Aggregation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VariableName.Length != 0) hash ^= VariableName.GetHashCode();
      if (InitialValueName.Length != 0) hash ^= InitialValueName.GetHashCode();
      if (InitializerName.Length != 0) hash ^= InitializerName.GetHashCode();
      if (SnapshotName.Length != 0) hash ^= SnapshotName.GetHashCode();
      if (saveSliceInfoDef_ != null) hash ^= SaveSliceInfoDef.GetHashCode();
      if (IsResource != false) hash ^= IsResource.GetHashCode();
      if (Trainable != false) hash ^= Trainable.GetHashCode();
      if (Synchronization != 0) hash ^= Synchronization.GetHashCode();
      if (Aggregation != 0) hash ^= Aggregation.GetHashCode();
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
      if (VariableName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VariableName);
      }
      if (InitializerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InitializerName);
      }
      if (SnapshotName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SnapshotName);
      }
      if (saveSliceInfoDef_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SaveSliceInfoDef);
      }
      if (IsResource != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsResource);
      }
      if (InitialValueName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(InitialValueName);
      }
      if (Trainable != false) {
        output.WriteRawTag(56);
        output.WriteBool(Trainable);
      }
      if (Synchronization != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Synchronization);
      }
      if (Aggregation != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Aggregation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VariableName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VariableName);
      }
      if (InitialValueName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InitialValueName);
      }
      if (InitializerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InitializerName);
      }
      if (SnapshotName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SnapshotName);
      }
      if (saveSliceInfoDef_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SaveSliceInfoDef);
      }
      if (IsResource != false) {
        size += 1 + 1;
      }
      if (Trainable != false) {
        size += 1 + 1;
      }
      if (Synchronization != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Synchronization);
      }
      if (Aggregation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Aggregation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VariableDef other) {
      if (other == null) {
        return;
      }
      if (other.VariableName.Length != 0) {
        VariableName = other.VariableName;
      }
      if (other.InitialValueName.Length != 0) {
        InitialValueName = other.InitialValueName;
      }
      if (other.InitializerName.Length != 0) {
        InitializerName = other.InitializerName;
      }
      if (other.SnapshotName.Length != 0) {
        SnapshotName = other.SnapshotName;
      }
      if (other.saveSliceInfoDef_ != null) {
        if (saveSliceInfoDef_ == null) {
          saveSliceInfoDef_ = new global::Tensorflow.SaveSliceInfoDef();
        }
        SaveSliceInfoDef.MergeFrom(other.SaveSliceInfoDef);
      }
      if (other.IsResource != false) {
        IsResource = other.IsResource;
      }
      if (other.Trainable != false) {
        Trainable = other.Trainable;
      }
      if (other.Synchronization != 0) {
        Synchronization = other.Synchronization;
      }
      if (other.Aggregation != 0) {
        Aggregation = other.Aggregation;
      }
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
            VariableName = input.ReadString();
            break;
          }
          case 18: {
            InitializerName = input.ReadString();
            break;
          }
          case 26: {
            SnapshotName = input.ReadString();
            break;
          }
          case 34: {
            if (saveSliceInfoDef_ == null) {
              saveSliceInfoDef_ = new global::Tensorflow.SaveSliceInfoDef();
            }
            input.ReadMessage(saveSliceInfoDef_);
            break;
          }
          case 40: {
            IsResource = input.ReadBool();
            break;
          }
          case 50: {
            InitialValueName = input.ReadString();
            break;
          }
          case 56: {
            Trainable = input.ReadBool();
            break;
          }
          case 64: {
            synchronization_ = (global::Tensorflow.VariableSynchronization) input.ReadEnum();
            break;
          }
          case 72: {
            aggregation_ = (global::Tensorflow.VariableAggregation) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SaveSliceInfoDef : pb::IMessage<SaveSliceInfoDef> {
    private static readonly pb::MessageParser<SaveSliceInfoDef> _parser = new pb::MessageParser<SaveSliceInfoDef>(() => new SaveSliceInfoDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaveSliceInfoDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.VariableReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSliceInfoDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSliceInfoDef(SaveSliceInfoDef other) : this() {
      fullName_ = other.fullName_;
      fullShape_ = other.fullShape_.Clone();
      varOffset_ = other.varOffset_.Clone();
      varShape_ = other.varShape_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSliceInfoDef Clone() {
      return new SaveSliceInfoDef(this);
    }

    /// <summary>Field number for the "full_name" field.</summary>
    public const int FullNameFieldNumber = 1;
    private string fullName_ = "";
    /// <summary>
    /// Name of the full variable of which this is a slice.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FullName {
      get { return fullName_; }
      set {
        fullName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "full_shape" field.</summary>
    public const int FullShapeFieldNumber = 2;
    private static readonly pb::FieldCodec<long> _repeated_fullShape_codec
        = pb::FieldCodec.ForInt64(18);
    private readonly pbc::RepeatedField<long> fullShape_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// Shape of the full variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> FullShape {
      get { return fullShape_; }
    }

    /// <summary>Field number for the "var_offset" field.</summary>
    public const int VarOffsetFieldNumber = 3;
    private static readonly pb::FieldCodec<long> _repeated_varOffset_codec
        = pb::FieldCodec.ForInt64(26);
    private readonly pbc::RepeatedField<long> varOffset_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// Offset of this variable into the full variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> VarOffset {
      get { return varOffset_; }
    }

    /// <summary>Field number for the "var_shape" field.</summary>
    public const int VarShapeFieldNumber = 4;
    private static readonly pb::FieldCodec<long> _repeated_varShape_codec
        = pb::FieldCodec.ForInt64(34);
    private readonly pbc::RepeatedField<long> varShape_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// Shape of this variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> VarShape {
      get { return varShape_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaveSliceInfoDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaveSliceInfoDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FullName != other.FullName) return false;
      if(!fullShape_.Equals(other.fullShape_)) return false;
      if(!varOffset_.Equals(other.varOffset_)) return false;
      if(!varShape_.Equals(other.varShape_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FullName.Length != 0) hash ^= FullName.GetHashCode();
      hash ^= fullShape_.GetHashCode();
      hash ^= varOffset_.GetHashCode();
      hash ^= varShape_.GetHashCode();
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
      if (FullName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FullName);
      }
      fullShape_.WriteTo(output, _repeated_fullShape_codec);
      varOffset_.WriteTo(output, _repeated_varOffset_codec);
      varShape_.WriteTo(output, _repeated_varShape_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FullName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FullName);
      }
      size += fullShape_.CalculateSize(_repeated_fullShape_codec);
      size += varOffset_.CalculateSize(_repeated_varOffset_codec);
      size += varShape_.CalculateSize(_repeated_varShape_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SaveSliceInfoDef other) {
      if (other == null) {
        return;
      }
      if (other.FullName.Length != 0) {
        FullName = other.FullName;
      }
      fullShape_.Add(other.fullShape_);
      varOffset_.Add(other.varOffset_);
      varShape_.Add(other.varShape_);
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
            FullName = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            fullShape_.AddEntriesFrom(input, _repeated_fullShape_codec);
            break;
          }
          case 26:
          case 24: {
            varOffset_.AddEntriesFrom(input, _repeated_varOffset_codec);
            break;
          }
          case 34:
          case 32: {
            varShape_.AddEntriesFrom(input, _repeated_varShape_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

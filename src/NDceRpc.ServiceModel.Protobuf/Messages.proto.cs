//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: data-contract serialization ([DataContract]/[DataMember]) enabled
    
// Generated from: Messages.proto
namespace NDceRpc.ServiceModel.Channels
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FaultData")]
  [global::System.Runtime.Serialization.DataContract(Name=@"FaultData")]
  public partial class FaultData : global::ProtoBuf.IExtensible
  {
    public FaultData() {}
    
    private string _Code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Code", Order = 1, IsRequired = true)]
    
    public string Code
    {
      get { return _Code; }
      set { _Code = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Name", Order = 2, IsRequired = true)]
    
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private string _Reason;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Reason", Order = 3, IsRequired = true)]
    
    public string Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
    private byte[] _Detail = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Detail", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Detail", Order = 4, IsRequired = false)]
    
    public byte[] Detail
    {
      get { return _Detail; }
      set { _Detail = value; }
    }
    private string _Node = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Node", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    [global::System.Runtime.Serialization.DataMember(Name=@"Node", Order = 5, IsRequired = false)]
    
    public string Node
    {
      get { return _Node; }
      set { _Node = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Message")]
  [global::System.Runtime.Serialization.DataContract(Name=@"Message")]
  public partial class Message : global::ProtoBuf.IExtensible
  {
    public Message() {}
    
    private byte[] _Data;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Data", Order = 1, IsRequired = true)]
    
    public byte[] Data
    {
      get { return _Data; }
      set { _Data = value; }
    }
    private FaultData _Fault = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Fault", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Fault", Order = 2, IsRequired = false)]
    
    public FaultData Fault
    {
      get { return _Fault; }
      set { _Fault = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpcParamData")]
  [global::System.Runtime.Serialization.DataContract(Name=@"RpcParamData")]
  public partial class RpcParamData : global::ProtoBuf.IExtensible
  {
    public RpcParamData() {}
    
    private int _Identifier;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Identifier", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Identifier", Order = 1, IsRequired = true)]
    
    public int Identifier
    {
      get { return _Identifier; }
      set { _Identifier = value; }
    }
    private byte[] _Data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Data", Order = 2, IsRequired = true)]
    
    public byte[] Data
    {
      get { return _Data; }
      set { _Data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageRequest")]
  [global::System.Runtime.Serialization.DataContract(Name=@"MessageRequest")]
  public partial class MessageRequest : global::ProtoBuf.IExtensible
  {
    public MessageRequest() {}
    
    private int _Operation;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Operation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Operation", Order = 1, IsRequired = true)]
    
    public int Operation
    {
      get { return _Operation; }
      set { _Operation = value; }
    }
    private readonly global::System.Collections.Generic.List<RpcParamData> _Data = new global::System.Collections.Generic.List<RpcParamData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"Data", Order = 2, IsRequired = false)]
    
    public global::System.Collections.Generic.List<RpcParamData> Data
    {
      get { return _Data; }
    }
  
    private string _Session = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    [global::System.Runtime.Serialization.DataMember(Name=@"Session", Order = 3, IsRequired = false)]
    
    public string Session
    {
      get { return _Session; }
      set { _Session = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEngineValueNode : CBehaviorGraphVariableNode
	{
		[Ordinal(1)] [RED("engineValueType")] 		public CEnum<EBehaviorEngineValueType> EngineValueType { get; set;}

		[Ordinal(2)] [RED("manualControl")] 		public CBool ManualControl { get; set;}

		public CBehaviorGraphEngineValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphEngineValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeTaskDefinition : IBehTreeObjectDefinition
	{
		[Ordinal(1)] [RED("listenToGameplayEvents", 2,0)] 		public CArray<CName> ListenToGameplayEvents { get; set;}

		[Ordinal(2)] [RED("listenToAnimEvents", 2,0)] 		public CArray<CName> ListenToAnimEvents { get; set;}

		public IBehTreeTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IBehTreeTaskDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BlockGameplayActionsTrigger : CGameplayEntity
	{
		[RED("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("sheatheWeaponIfDrawn")] 		public CBool SheatheWeaponIfDrawn { get; set;}

		public W3BlockGameplayActionsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BlockGameplayActionsTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
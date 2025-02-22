using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationTrajectoryPlayerInput : CVariable
	{
		[Ordinal(1)] [RED("localToWorld")] 		public CMatrix LocalToWorld { get; set;}

		[Ordinal(2)] [RED("pointWS")] 		public Vector PointWS { get; set;}

		[Ordinal(3)] [RED("directionWS")] 		public Vector DirectionWS { get; set;}

		[Ordinal(4)] [RED("tagId")] 		public CName TagId { get; set;}

		[Ordinal(5)] [RED("selectorType")] 		public CEnum<EAnimationTrajectorySelectorType> SelectorType { get; set;}

		[Ordinal(6)] [RED("proxySyncType")] 		public CEnum<EActionMoveAnimationSyncType> ProxySyncType { get; set;}

		[Ordinal(7)] [RED("proxy")] 		public CHandle<CActionMoveAnimationProxy> Proxy { get; set;}

		public SAnimationTrajectoryPlayerInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationTrajectoryPlayerInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
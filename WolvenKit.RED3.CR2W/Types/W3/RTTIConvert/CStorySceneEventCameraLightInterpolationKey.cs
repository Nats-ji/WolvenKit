using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCameraLightInterpolationKey : CVariable
	{
		[Ordinal(1)] [RED("bezierHandles", 2)] 		public CArrayFixedSize<Bezier2dHandle> BezierHandles { get; set;}

		[Ordinal(2)] [RED("interpolationTypes", 2)] 		public CArrayFixedSize<CUInt32> InterpolationTypes { get; set;}

		[Ordinal(3)] [RED("volatile")] 		public CBool Volatile { get; set;}

		public CStorySceneEventCameraLightInterpolationKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventCameraLightInterpolationKey(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
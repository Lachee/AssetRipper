using AssetRipper.Project;
using AssetRipper.Classes.Misc;
using AssetRipper.IO.Asset;
using AssetRipper.YAML;
using System;

namespace AssetRipper.Classes.AnimatorController.Constants
{
	public struct SelectorTransitionConstant : IAssetReadable, IYAMLExportable
	{
		public void Read(AssetReader reader)
		{
			Destination = unchecked((int)reader.ReadUInt32());
			ConditionConstantArray = reader.ReadAssetArray<OffsetPtr<ConditionConstant>>();
		}

		public YAMLNode ExportYAML(IExportContainer container)
		{
			throw new NotSupportedException();
		}

		public int Destination { get; set; }
		public OffsetPtr<ConditionConstant>[] ConditionConstantArray { get; set; }
	}
}
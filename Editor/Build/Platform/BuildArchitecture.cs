using System;
using UnityEditor;

namespace SuperUnityBuild.BuildTool
{
    [Serializable]
    public class BuildArchitecture
    {
        public BuildTarget target;
        public string name;
        public bool enabled;
        public string binaryNameFormat;
        public bool isARM;

        public BuildArchitecture(BuildTarget target, string name, bool enabled, string binaryNameFormat, bool isARM = false)
        {
            this.target = target;
            this.name = name;
            this.enabled = enabled;
            this.binaryNameFormat = binaryNameFormat;
            this.isARM = isARM;
        }

        public override string ToString()
        {
            return name;
        }
    }
}

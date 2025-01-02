using System;

namespace DotsStorageManager.ECS
{
    [Serializable]
    public class DotModel
    {
        public string prefab_name;
        // position
        public int position_x;
        public int position_y;

        public override string ToString()
        {
            return $"{prefab_name}({position_x}, {position_y})";
        }
    }
}
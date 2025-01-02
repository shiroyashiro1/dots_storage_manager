using UnityEngine;

namespace DotsStorageManager.ECS
{
    public interface ISystem
    {
        public void Update(GameObject dot);
    }
}
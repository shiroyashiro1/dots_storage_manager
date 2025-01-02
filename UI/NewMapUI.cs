using UnityEngine;

namespace DotsStorageManager.UI
{
    public class ClearMapUI : MonoBehaviour
    {
        public Transform rootGameObject;

        public void ClearMap()
        {
            for (int i = 0; i < rootGameObject.childCount; i++)
            {
                Destroy(rootGameObject.GetChild(i).gameObject);
            }
        }
    }
}
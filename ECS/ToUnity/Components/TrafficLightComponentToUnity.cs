using UnityEngine;

namespace DotsStorageManager.ECS
{
    public class TrafficLightComponentToUnity : MonoBehaviour
    {
        public Color redLight = Color.red;
        public Color greenLight = Color.green;
        public float delay = new();
    }
}

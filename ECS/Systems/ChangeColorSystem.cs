using System.Collections;
using UnityEngine;

namespace DotsStorageManager.ECS
{
    public class ChangeColorSystem : ISystem
    {
        // stub
        public void Update(GameObject dot)
        {
            var tflC = dot.GetComponent<TrafficLightComponentToUnity>();
        }
    }
}
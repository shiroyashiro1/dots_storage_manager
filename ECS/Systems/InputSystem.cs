using DotsStorageManager.ECS.ToUnity;
using UnityEngine;

namespace DotsStorageManager.ECS
{
    public class InputSystem : ISystem
    {
        public void Update(GameObject dot)
        {
            var movC = dot.GetComponent<MoveComponentToUnity>();
            if (movC)
            {                
                dot.transform.position += (Vector3)(movC.Direction * movC.Speed * Time.deltaTime);
            }
        }
    }
}
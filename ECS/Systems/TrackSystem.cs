using System;
using DotsStorageManager.ECS.ToUnity;
using UnityEngine;

namespace DotsStorageManager.ECS
{
    public class TrackSystem : ISystem
    {
        // stub
        public void Update(GameObject dot)
        {
            var movC = dot.GetComponent<TrackMoveComponentToUnity>();
            if (movC)
            {
                var tmpDir = movC.Track[(movC.Segment + 1) % movC.Track.Count] - movC.Track[movC.Segment];
                movC.Direction = new Vector2(Math.Sign(tmpDir.x), Math.Sign(tmpDir.y));
                
                dot.transform.position += (Vector3)(movC.Direction * movC.Speed * Time.deltaTime);
            }
        }
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace DotsStorageManager.ECS.ToUnity
{
    public class TrackMoveComponentToUnity : MonoBehaviour
    {
        public int Segment = new();
        public List<Vector2> Track = new();
        public Vector2 Direction = new();
        public float Speed = new();
        public float delay = new();
    }
}
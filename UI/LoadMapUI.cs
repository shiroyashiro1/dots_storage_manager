using TMPro;
using UnityEngine;

namespace DotsStorageManager.UI
{
    public class LoadMapUI : MonoBehaviour
    {
        public TMP_Text textComponent;
        public MapGenerator mapGenerator;

        public void LoadMap()
        {
            mapGenerator.LoadLevel(textComponent.text);
            mapGenerator.LoadLevelToScene();
        }
    }
}
using TMPro;
using UnityEngine;

namespace DotsStorageManager.UI
{
    public class SaveMapUI : MonoBehaviour
    {
        public TMP_Text textComponent;
        public MapScanner mapScanner;

        public void SaveMap()
        {
            mapScanner.mapKey = textComponent.text;
            mapScanner.SaveSceneMap();
        }
    }
}
using UnityEngine;
using System.Collections;

public class ChangeLevel1 : MonoBehaviour {

    public GameObject loadingImage;

    public void NextLevelButton(string levelName)
    {
        loadingImage.SetActive(true);
        Application.LoadLevel(levelName);
    }
}

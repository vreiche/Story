using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

    public void NextLevelButton(string levelName)
    {
        Application.LoadLevel(levelName);
    }
}

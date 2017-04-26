using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 300, 80), "Start Game"))
        {
        
            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
        }
    }
}
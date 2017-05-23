using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 3 + 125, 350, 150), "Start Game"))  //Creates Button to press to start level
        {

            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
        }
    }
}
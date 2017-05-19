using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(685, 450, 300, 80), "Start Game"))  //Creates Button to press to start level
        {

            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
        }
    }
}
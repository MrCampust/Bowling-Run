using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(685, 650, 300, 80), "Exit Game"))
        {
            Application.Quit();

        }
    }
}
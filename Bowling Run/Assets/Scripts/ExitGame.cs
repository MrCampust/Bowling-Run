using UnityEngine;

public class ExitGame : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(685, 650, 300, 80), "Exit Game")) //creates a button called Exit Game
        {
            Application.Quit();

        }
    }
}
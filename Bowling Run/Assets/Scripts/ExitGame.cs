using UnityEngine;

public class ExitGame : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 340, 350, 150), "Exit Game")) //creates a button called Exit Game
        {
            Application.Quit();

        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {


    private bool mShowGUIButton = true;
    private Rect mButtonRect = new Rect(50, 380, 400, 200);

    void OnGUI()
    {
        if (mShowGUIButton)
        {
            // draw the GUI button
            if (GUI.Button(mButtonRect, "Back"))
            {
                SceneManager.LoadScene("ar2");


                // do something on button click 
            }
        }
    }
}

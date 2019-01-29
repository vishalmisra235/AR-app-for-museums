using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.SceneManagement;

public class NanditextScript : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;

    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50, 50, 400, 200);

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
    }

    void OnGUI()
    {
        {
            // draw the GUI button
        if (mShowGUIButton)
            if (GUI.Button(mButtonRect, "Info"))
            {
                SceneManager.LoadScene("nanditextscene");
                // do something on button click 
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerQuitGame : MonoBehaviour
{

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
		    Application.Quit();
        }

    }
}

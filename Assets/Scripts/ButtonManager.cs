using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //return to SampleScene
    public void RestartBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    //quit game
    public void QuitBtn()
    {
        Application.Quit();
    }
}

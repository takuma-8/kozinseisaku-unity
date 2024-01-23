using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{

    public void Retry_Bottan()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void StageSlect()
    {
        SceneManager.LoadScene("StageScene");
    }
}

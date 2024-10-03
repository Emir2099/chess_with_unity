using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}

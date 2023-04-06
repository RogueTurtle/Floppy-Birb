using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}

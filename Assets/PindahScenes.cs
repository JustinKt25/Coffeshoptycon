using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahScenes : MonoBehaviour
{
    public void PindahScene(string Gameplay)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Gameplay);
    }
}

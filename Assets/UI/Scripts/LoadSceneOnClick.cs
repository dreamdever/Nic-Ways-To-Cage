using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {
    
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadRandom()
    {
        int[] levels = { 2,4 };
        int randLevel = Random.Range(0, levels.Length);
        SceneManager.LoadScene(levels[randLevel]);
    }
}

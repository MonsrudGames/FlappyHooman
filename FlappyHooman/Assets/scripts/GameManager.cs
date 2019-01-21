using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public void RestartGame(){
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(0));
    }

}
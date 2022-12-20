using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement Singleton;
    
    private void Awake()
    {
        Singleton = this;
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }
    
    private void OnLoadScene(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene loaded: " + scene.name);
        Actions.OnLoadScene?.Invoke(new GameEventContext(scene.name));
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLoadScene;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLoadScene;
    }
}
using UnityEngine;
using UnityEngine.UI;

// ReSharper disable All

public class MainUI : MonoBehaviour
{
    [SerializeField] private Button _playBtn;
    [SerializeField] private Button _optionsBtn;
    [SerializeField] private Button _quitBtn;

    private void Awake()
    {
        _playBtn.onClick.AddListener((() => SceneManagement.Singleton.LoadScene("GameScene")));
        _quitBtn.onClick.AddListener((() => Application.Quit()));
    }
}

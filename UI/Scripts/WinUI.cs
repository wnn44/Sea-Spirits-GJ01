using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : UI
{
    [SerializeField] private GameObject[] _winDialogsUI;
    [SerializeField] private int _iteration;

    
    public void ShowWindow()
    {
        for (int i = 0; i < _winDialogsUI.Length; i++)
        {
            _winDialogsUI[i].SetActive(false);
            _winDialogsUI[_iteration].SetActive(true);
        }
        
        _iteration += 1; 
    }

    public void CloseWindow()
    {
        _winDialogsUI[_iteration-1].SetActive(false);
    }

    public void RestartScene()
    {
        _winDialogsUI[_iteration-1].SetActive(false);
        SceneManager.LoadScene(0);
    }
}

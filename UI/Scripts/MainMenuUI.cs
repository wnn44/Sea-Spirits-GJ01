using UnityEngine;

public class MainMenuUI : UI
{
    [Header("MainMenu MainMenuUI")]
    [SerializeField] private GameObject _mainMenuUI;
    
    [SerializeField] private bool _isOpenMainMenu;

    private float _closeDelay = 0.2f;
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;
        
        if (Input.GetKey(KeyCode.Escape) && _closeDelay < _time)
        {
            _time = 0;
            
            _isOpenMainMenu = !_isOpenMainMenu;
            _mainMenuUI.SetActive(_isOpenMainMenu);
        }
    }

    public void CloseMainMenuWindow()
    {
        _isOpenMainMenu = false;
        _mainMenuUI.SetActive(_isOpenMainMenu);
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Timer timer;
    [SerializeField] private Ball player;
    [SerializeField] private Platform platform;
    [SerializeField] private float smoothInputSpeed;
    [SerializeField] private TouchJoystick touchJoystick;

    private UIController _ui;
    
    private void Awake()
    {
        _ui = GetComponent<UIController>();
        _ui.ShowStartScreen();
        timer.enabled = false;
        Time.timeScale = 0;
        
        player.OnDeath += OnPlayerDeath;
        
        SetPlatformInput();
    }

    private void SetPlatformInput()
    {
        platform.MaxAngle = 25;
        platform.Input = new SmoothInput(smoothInputSpeed, new SumControl(
                new I2DInput[] {new WSADControl(), touchJoystick}
            ));
    }

    private void OnPlayerDeath()
    {
        Time.timeScale = 0;
        _ui.ShowRestartScreen();
    }
    
    public void PlayGame()
    {
        timer.enabled = true;
        timer.Reset();
        player.Reset();
        _ui.HideUI();
        Time.timeScale = 1;
        timer.Reset();
    }
}

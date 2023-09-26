using UnityEngine;
using UnityEngine.UI;

public class DefeatPanel : MonoBehaviour
{
    [SerializeField] private Button _butRestart;

    private GamePlayMediator _mediator;

    public void Initialize(GamePlayMediator mediator)
    {
        _mediator = mediator;
    }
    public void Hiden() => gameObject.SetActive(false);

    public void Show() => gameObject.SetActive(true);

    private void OnEnable() => _butRestart.onClick.AddListener(OnRestartClick);

    private void OnDisable() => _butRestart.onClick.RemoveListener(OnRestartClick);

    private void OnRestartClick() => _mediator.RestartLevel();
    
}

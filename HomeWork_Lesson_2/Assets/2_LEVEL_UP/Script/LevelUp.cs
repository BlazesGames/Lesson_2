using UnityEngine;
using UnityEngine.UI;


public class LevelUp : MonoBehaviour
{
    [SerializeField] private Button _butLevelUp;
    private GamePlayMediator _mediator;

    public void Initialize(GamePlayMediator mediator)
    {
        _mediator = mediator;
    }

    private void OnEnable()
    {
        _butLevelUp.onClick.AddListener(OnClickLevelUp);
    }

    private void OnDisable()
    {
        _butLevelUp.onClick.RemoveListener(OnClickLevelUp);
    }

    public void OnClickLevelUp() => _mediator.LevelUp();

}

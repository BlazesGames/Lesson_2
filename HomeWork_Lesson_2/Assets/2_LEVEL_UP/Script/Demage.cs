using UnityEngine;
using UnityEngine.UI;


public class Demage : MonoBehaviour
{
    [SerializeField] private Button _butDamage;

    private GamePlayMediator _mediator;

    public void Initialize(GamePlayMediator mediator)
    {
        _mediator = mediator;
    }

    private void OnEnable()
    {
        _butDamage.onClick.AddListener(OnClickDemage);
    }

    private void OnDisable()
    {
        _butDamage.onClick.RemoveListener(OnClickDemage);
    }

    public void OnClickDemage() => _mediator.Damage();
}

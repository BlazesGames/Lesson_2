using UnityEngine;
using UnityEngine.UI;

public class TextInfo : MonoBehaviour
{
    [SerializeField] private Text _textHp;
    [SerializeField] private Text _textLevel;

    private GamePlayMediator _mediator;

    public void Initialize(GamePlayMediator mediator)
    {
        _mediator = mediator;
    }

    public void ShowHp(CharterData data)
    {
        _textHp.text = data.Hp.ToString();
    }

    public void ShowLevel(CharterData data)
    {
        _textLevel.text = data.LevelStart.ToString();
    }

}

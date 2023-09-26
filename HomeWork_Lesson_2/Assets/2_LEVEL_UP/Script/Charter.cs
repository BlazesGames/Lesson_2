using UnityEngine;

public class Charter : MonoBehaviour
{
    public CharterData _charterData;

    private GamePlayMediator _mediator;

    public void Initialize(GamePlayMediator mediator)
    {
        _mediator = mediator;
        _charterData = new CharterData();
    }

    public void LevelUp()
    {
        _charterData.Hp += _charterData.HpPlus;
        _charterData.LevelStart += 1;
    }
    public void Damage()
    {
        if (_charterData.Hp > 0)
        {
            _charterData.Hp -= _charterData.Damage;
        }
        else
        {
            _charterData.Hp = 0;
            _mediator.OnLevelSceneDefeat();
        }
    }

    

}

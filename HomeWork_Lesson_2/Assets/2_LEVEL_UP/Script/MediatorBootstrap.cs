using UnityEngine;

public class MediatorBootstrap : MonoBehaviour
{
    [SerializeField] private GamePlayMediator _gamePlayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private LevelUp _levelUp;
    [SerializeField] private Demage _demage;
    [SerializeField] private Charter _charter;
    [SerializeField] private TextInfo _textInfo;

    private void Awake()
    {
        _defeatPanel.Initialize(_gamePlayMediator);
        _levelUp.Initialize(_gamePlayMediator);
        _demage.Initialize(_gamePlayMediator);
        _charter.Initialize(_gamePlayMediator);
        _textInfo.Initialize(_gamePlayMediator);
    }
}

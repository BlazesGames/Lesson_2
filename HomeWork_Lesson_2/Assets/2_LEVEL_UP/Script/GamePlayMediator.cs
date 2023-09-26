using UnityEngine;

public class GamePlayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private LevelUp _levelUp;
    [SerializeField] private Demage _demage;
    [SerializeField] private Charter _charter;
    [SerializeField] private TextInfo _textInfo;

    public void RestartLevel()
    {
        _charter._charterData.RestartData();
        _textInfo.ShowHp(_charter._charterData);
        _textInfo.ShowLevel(_charter._charterData);
        _defeatPanel.Hiden();
    }

    public void LevelUp()
    {
        _charter.LevelUp();
        _textInfo.ShowLevel(_charter._charterData);
        _textInfo.ShowHp(_charter._charterData);
    }
    public void Damage()
    {
        _charter.Damage();
        _textInfo.ShowHp(_charter._charterData);
    }

    public void OnLevelSceneDefeat() => _defeatPanel.Show();
    
}

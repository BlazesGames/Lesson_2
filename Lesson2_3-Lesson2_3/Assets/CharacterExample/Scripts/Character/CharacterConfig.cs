using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName ="Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private WalkStateConfig _walkStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public WalkStateConfig WalkStateConfig => _walkStateConfig;

    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
}

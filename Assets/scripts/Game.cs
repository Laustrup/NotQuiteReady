namespace scripts
{
    public class Game
    {
        void Start() { AddGameToScenes(); }

        void AddGameToScenes() { SceneMaster.Instance.CountScene(); }
    }
}
using System;
using UnityEngine.SceneManagement;

namespace scripts
{
    public sealed class SceneMaster
    {
        private SceneMaster() {}
        private static SceneMaster _instance = null;
        public static SceneMaster Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SceneMaster();
                }
                return _instance;
            }
        }
        
        private int _sceneCount = 0;
        
        public void ChangeGame()
        {
            SceneManager.LoadScene(new Random().Next(this._sceneCount)+2);
        }

        public void CountScene() { this._sceneCount++; }
    }
}
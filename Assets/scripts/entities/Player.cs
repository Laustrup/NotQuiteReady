using System;
using UnityEngine;

namespace scripts.entities
{
    public class Player : MonoBehaviour
    {
        private int _health { get; set; } public int Health { get => _health; }
        private int _score { get; set; } public int Score { get => _score; }
        private int _games { get; set; } public int Games { get => _games; }
        public double FinalScore { get => _time.Seconds / _games * _score; }
        private DateTime start { get; set; }
        private TimeSpan _time { get; set; } public TimeSpan Seconds { get => _time; }
        private bool gg { get; set; } public bool GG { get => gg; }

        // Start is called before the first frame update
        void Start()
        {
            _health = 5;
            _score = 0;
            start = DateTime.Now;
            gg = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (_health == 0) { gg = true; }
            else { _time = DateTime.Now - start; }
        }

        void LoseHealth() { _health--; }

        void AddScore(int score)
        {
            _score += score;
            _games++;
            SceneMaster.Instance.ChangeGame();
        }
        
    }
}
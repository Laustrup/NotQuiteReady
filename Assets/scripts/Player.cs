using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health { get; set; } public int Health { get => _health; }
    private int _score { get; set; } public int Score { get => _score; }
    private DateTime start { get; set; }
    private float _seconds { get; set; } public float Seconds { get => _seconds; }

    // Start is called before the first frame update
    void Start()
    {
        _health = 5;
        _score = 0;
        start = DateTime.Now;
        _seconds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = TimeSpan.FromSeconds(start);
        _seconds = TimeSpan.FromSeconds(start);
    }
}

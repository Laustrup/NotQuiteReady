using System.Collections.Generic;
using scripts.enums;
using UnityEngine;

namespace scripts
{
    public class Game : MonoBehaviour
    {
        protected string _title { get; } public string Title { get => _title; }
        protected List<GameTag> _tags { get; } public List<GameTag> Tags { get => _tags; }
        
        void Start() { AddGameToScenes(); }

        public Game(List<GameTag> tags)
        {
            _tags = tags;
            
        }

        void AddGameToScenes() { SceneMaster.Instance.CountScene(); }
    }
}
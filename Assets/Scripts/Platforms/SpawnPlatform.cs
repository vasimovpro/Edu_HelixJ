using System;
using UnityEngine;

namespace Platforms
{
    public class SpawnPlatform: Platform
    {
        [SerializeField] private Ball _ball;
        [SerializeField] private Transform _spawnPoint;

        private void Awake()
        {
            Instantiate(_ball, _spawnPoint.position, Quaternion.identity);
        }
    }
}
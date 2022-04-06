using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject _player;
    [SerializeField]
    GameObject _victoryScreen;

    private void Awake()
    {
            _victoryScreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player)
        {
            _victoryScreen.SetActive(true);
            Application.Quit();
        }
    }
}

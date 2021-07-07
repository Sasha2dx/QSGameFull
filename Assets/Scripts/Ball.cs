using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public event Action OnDeath;
    
    private Rigidbody _rigidbody;
    private Vector3 _startPos;
    private float _deathAttitude;
    private bool _dead;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.sleepThreshold = 0;
        _startPos = transform.position;
        _deathAttitude = _startPos.y - 15f;
    }

    public void Reset()
    {
        transform.position = _startPos;
        _dead = false;
        _rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        if (!_dead && transform.position.y < _deathAttitude)
        {
            OnDeath?.Invoke();
            _dead = true;
        }
    }
}

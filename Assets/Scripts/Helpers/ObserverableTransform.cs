using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverableTransform : MonoBehaviour
{
    [SerializeField] private Vector3 _lastPose;
    [SerializeField] private Transform _transform;
    public event Action<Transform> OnChangePosition;
    private void Start()
    {
        _transform = GetComponent<Transform>();
        _lastPose = _transform.position;
    }
    private void Update()
    {
        if(_transform.position != _lastPose)
        {
            if(OnChangePosition != null)
            {
                OnChangePosition.Invoke(_transform);
            }
        }
        _lastPose = transform.position;
    }
}

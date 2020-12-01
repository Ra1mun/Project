using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SquadController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent[] _agents;
    [SerializeField] private ICreateSquadCenter _generator;
    [SerializeField] private GestureClick _click;
    public Transform Target;
    private void Start()
    {
        _generator = GetComponent<ICreateSquadCenter>();
        Target.GetOrAddComponent<Transform, ObserverableTransform>().OnChangePosition += (target) =>
        {
            SquadControl(target.position);
        };
    }
    private void Update()
    {
        _click.OnClick.AddListener((changePositonTarget) =>
        {
            Target.position = changePositonTarget;
        });
    }
    private void SquadControl(Vector3 center)
    {
        var positions = _generator.GetPositions(_agents.Length - 1);
        for(int i = 0; i < _agents.Length; i++)
        {
            _agents[i].SetDestination(positions[i] * 3);
        }
    }
}

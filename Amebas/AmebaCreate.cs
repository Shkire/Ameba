using UnityEngine;
using System.Collections;

public class AmebaCreate : Ameba {

    [SerializeField]
    private GameObject _model;

    [SerializeField]
    private bool _targetRotation;

    public override void PerformBehaviour()
    {
        if (_targetRotation)
            Instantiate(_model, _target.position, _target.rotation);
        else
            Instantiate(_model, _target.position, _model.transform.rotation);
    }

}

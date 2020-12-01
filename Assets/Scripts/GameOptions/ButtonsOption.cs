using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsOption : MonoBehaviour
{
    class ThrowGrenadeInput
    {
        [SerializeField] private GreandeThrower _grenadeThrower;
        private void Update()
        {
            _grenadeThrower.Throw(ButtonThrow());
        }
        public bool ButtonThrow()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}

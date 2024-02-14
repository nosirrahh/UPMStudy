using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UPMStudy
{
    public class HelloWorld : MonoBehaviour
    {
        #region Unity Methods

        private void Start ()
        {
            Debug.Log ($"Start: {nameof (HelloWorld)}");
        }

        private void Update ()
        {
            Debug.Log ($"Update: {nameof (HelloWorld)}");
        }

        #endregion
    }
}
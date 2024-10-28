using System;
using UnityEngine;

namespace CCLBStudio.ScriptablePooling
{
    public class DefaultPooledObject : MonoBehaviour, IScriptablePooledObject
    {
        public ScriptablePool Pool { get; set; }

        public void OnObjectCreated(ScriptablePool objectPool)
        {
            
        }
    }
}

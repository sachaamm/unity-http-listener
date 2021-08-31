using System;
using UnityEngine;

namespace Scripts.Service
{
    public abstract class UnityHttpListenerDataInjectorBehaviour : MonoBehaviour
    {
        private bool requestReceived = false;
        
        private void Start()
        {
            // UnityHttpListenerReceiveRequestService.OnReceiveRequest += ReceiveRequest;
        }
        
        private void OnDestroy()
        {
            // UnityHttpListenerReceiveRequestService.OnReceiveRequest -= ReceiveRequest;
        }
        
        void ReceiveRequest(object send, bool b)
        {
            requestReceived = true;
        }

        void Update()
        {
            if (requestReceived)
            {
                InjectData();
                requestReceived = false;
            }
        }

        protected abstract void InjectData();
    }
}
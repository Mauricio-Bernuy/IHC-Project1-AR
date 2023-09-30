using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CW.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Lean.Gui
{
    public class showWelcome : MonoBehaviour
    {
        private LeanWindow _welcomeWindow;
        
        // Start is called before the first frame update
        async void Start()
        {
            _welcomeWindow = this.GetComponent<LeanWindow>();
            await Task.Delay(1000);
            _welcomeWindow.On = true;
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
    }
}
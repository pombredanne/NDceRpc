﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Threading;

namespace NDceRpc.ServiceModel
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallbackServiceCallback))]
    [Guid("FC20F4E4-E3F7-4D60-8FBC-94FF85FF835D")]
    public interface ICallbackService
    {
        [OperationContract(IsOneWay = false)]
        void Call();
    }





    public class CallbackService : ICallbackService
    {




        public void Call()
        {
            var callback = RpcOperationContext.Current.GetCallbackChannel<ICallbackServiceCallback>();
            callback.OnOneWayCallback();
        }


    }

    [Guid("0C083E9E-AED0-4335-A446-AA40264B4484")]
    public interface ICallbackServiceCallback
    {


        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void OnOneWayCallback();
    }

    public class CallbackServiceCallback : ICallbackServiceCallback
    {
        public ManualResetEvent Wait { get; set; }


        public CallbackServiceCallback()
        {
            Wait = new ManualResetEvent(false);
        }





        public void OnOneWayCallback()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + " was called in " + Process.GetCurrentProcess().Id);
            Wait.Set();
        }
    }


}

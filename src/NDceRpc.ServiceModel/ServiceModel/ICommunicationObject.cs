﻿//
// System.ServiceModel.ICommunicationObject.cs
//
// Author: Duncan Mak (duncan@novell.com)
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace NDceRpc.ServiceModel
{

    public interface ICommunicationObject
    {
        CommunicationState State { get; }

        void Abort();

        IAsyncResult BeginClose(AsyncCallback callback, object state);

        IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);

        IAsyncResult BeginOpen(AsyncCallback callback, object state);

        IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);

        void Close();

        void Close(TimeSpan timeout);

        void EndClose(IAsyncResult result);

        void EndOpen(IAsyncResult result);

        void Open();

        void Open(TimeSpan timeout);

        event EventHandler Closed;
        event EventHandler Closing;
        event EventHandler Faulted;
        event EventHandler Opened;
        event EventHandler Opening;
    }
}
// DceRpcIdlClient.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <stdio.h>
#include <assert.h>
#include <string.h>
#include <wchar.h>
#include <tchar.h>
#include <WinBase.h>
#include "DceRpcIdlClient.h"
#include "..\DceRpc.Idl\Dummy_h.h"
#include <stdlib.h>
#include "..\DceRpc.Idl\ExplicitWithCallbacks_h.h"

DCERPCIDLCLIENT_API void CallDummyServer(void* bindingHandle)
{
	Do(bindingHandle);
}

/* [callback] */ void CallClient( 
	/* [string][in] */ wchar_t *szOutput){
		wprintf(szOutput);
		printf("\n");
}

DWORD WINAPI StartListening(PVOID pvParam) {
   
	RPC_ASYNC_STATE Async;
	RPC_STATUS status;

	// Initialize the handle.
	status = RpcAsyncInitializeHandle(&Async, sizeof(RPC_ASYNC_STATE));
	if (status)
	{
		assert (status == RPC_S_OK);
	}

	Async.UserInfo = NULL;
	Async.NotificationType = RpcNotificationTypeEvent;

	Async.u.hEvent = CreateEvent(NULL, FALSE, FALSE, NULL);
	if (Async.u.hEvent == 0)
	{
		// Code to handle the error goes here.
	}

	
		
	AsyncAttach(
		//&Async,
		pvParam,_TEXT("Start waiting callback"));
   return S_OK;
}

HANDLE g_requestTread;

DCERPCIDLCLIENT_API void CallExplicitWithCallbacksServer(void* bindingHandle)
{
	 DWORD dwThreadID = -1;
	g_requestTread = CreateThread(NULL, 0, StartListening,bindingHandle, 0,&dwThreadID);
	Sleep(500);
	Request(bindingHandle,_TEXT("Hello from client!!!"));
	Sleep(500);
	Request(bindingHandle,_TEXT("Hello from client!!!"));
	Sleep(500);
	Request(bindingHandle,_TEXT("Hello from client!!!"));
	Sleep(500);
	Request(bindingHandle,_TEXT("Hello from client!!!"));
}

DCERPCIDLCLIENT_API void* GetDummyClient()
{
	return Dummy_v0_1_c_ifspec;
}

void* __RPC_USER midl_user_allocate(size_t size)
{
	return malloc(size);
}


void __RPC_USER midl_user_free(void* p)
{
	free(p);
}
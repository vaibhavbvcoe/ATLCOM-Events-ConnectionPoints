// dllmain.cpp : Implementation of DllMain.

#include "stdafx.h"
#include "resource.h"
#include "simplefish_i.h"
#include "dllmain.h"
#include "xdlldata.h"

CsimplefishModule _AtlModule;

class CsimplefishApp : public CWinApp
{
public:

// Overrides
	virtual BOOL InitInstance();
	virtual int ExitInstance();

	DECLARE_MESSAGE_MAP()
};

BEGIN_MESSAGE_MAP(CsimplefishApp, CWinApp)
END_MESSAGE_MAP()

CsimplefishApp theApp;

BOOL CsimplefishApp::InitInstance()
{
#ifdef _MERGE_PROXYSTUB
	if (!PrxDllMain(m_hInstance, DLL_PROCESS_ATTACH, NULL))
		return FALSE;
#endif
	return CWinApp::InitInstance();
}

int CsimplefishApp::ExitInstance()
{
	return CWinApp::ExitInstance();
}

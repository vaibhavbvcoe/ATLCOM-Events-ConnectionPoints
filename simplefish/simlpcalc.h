// simlpcalc.h : Declaration of the Csimlpcalc

#pragma once
#include "resource.h"       // main symbols



#include "simplefish_i.h"
#include "_IsimlpcalcEvents_CP.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// Csimlpcalc

class ATL_NO_VTABLE Csimlpcalc :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<Csimlpcalc, &CLSID_simlpcalc>,
	public ISupportErrorInfo,
	public IConnectionPointContainerImpl<Csimlpcalc>,
	public CProxy_IsimlpcalcEvents<Csimlpcalc>,
	public IObjectWithSiteImpl<Csimlpcalc>,
	public IDispatchImpl<Isimlpcalc, &IID_Isimlpcalc, &LIBID_simplefishLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	Csimlpcalc()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_SIMLPCALC)


BEGIN_COM_MAP(Csimlpcalc)
	COM_INTERFACE_ENTRY(Isimlpcalc)
	COM_INTERFACE_ENTRY(IDispatch)
	COM_INTERFACE_ENTRY(ISupportErrorInfo)
	COM_INTERFACE_ENTRY(IConnectionPointContainer)
	COM_INTERFACE_ENTRY(IObjectWithSite)
END_COM_MAP()

BEGIN_CONNECTION_POINT_MAP(Csimlpcalc)
	CONNECTION_POINT_ENTRY(__uuidof(_IsimlpcalcEvents))
END_CONNECTION_POINT_MAP()
// ISupportsErrorInfo
	STDMETHOD(InterfaceSupportsErrorInfo)(REFIID riid);


	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

public:



	STDMETHOD(Calculate)(VARIANT_BOOL a_bFireEvent, LONG* a_lTotalMarks);
	STDMETHOD(get_ComMark)(LONG* pVal);
	STDMETHOD(put_ComMark)(LONG newVal);
	STDMETHOD(get_AtlMarks)(LONG* pVal);
	STDMETHOD(put_AtlMarks)(LONG newVal);
	STDMETHOD(get_StudentName)(BSTR* pVal);
	STDMETHOD(put_StudentName)(BSTR newVal);
private:
	long m_lComMarks,m_lATLMarks,m_lTotalMarks;
	CComBSTR m_bstStudName;
};

OBJECT_ENTRY_AUTO(__uuidof(simlpcalc), Csimlpcalc)

// simlpcalc.cpp : Implementation of Csimlpcalc

#include "stdafx.h"
#include "simlpcalc.h"


// Csimlpcalc

STDMETHODIMP Csimlpcalc::InterfaceSupportsErrorInfo(REFIID riid)
{
	static const IID* const arr[] = 
	{
		&IID_Isimlpcalc
	};

	for (int i=0; i < sizeof(arr) / sizeof(arr[0]); i++)
	{
		if (InlineIsEqualGUID(*arr[i],riid))
			return S_OK;
	}
	return S_FALSE;
}


STDMETHODIMP Csimlpcalc::Calculate(VARIANT_BOOL a_bFireEvent, LONG* a_lTotalMarks)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	*a_lTotalMarks = m_lATLMarks + m_lComMarks;
	if(a_bFireEvent == VARIANT_TRUE)
		Fire_TotalMarks(*a_lTotalMarks);

	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::get_ComMark(LONG* pVal)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	*pVal = m_lComMarks;
	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::put_ComMark(LONG newVal)
{
	
	AFX_MANAGE_STATE(AfxGetStaticModuleState());
	m_lComMarks = newVal;
	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::get_AtlMarks(LONG* pVal)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	*pVal=  m_lATLMarks;
	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::put_AtlMarks(LONG newVal)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());
	m_lATLMarks = newVal;
	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::get_StudentName(BSTR* pVal)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	*pVal =m_bstStudName.Copy(); 
	// TODO: Add your implementation code here

	return S_OK;
}


STDMETHODIMP Csimlpcalc::put_StudentName(BSTR newVal)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());
	m_bstStudName =  newVal;
	// TODO: Add your implementation code here

	return S_OK;
}

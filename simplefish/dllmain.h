// dllmain.h : Declaration of module class.

class CsimplefishModule : public ATL::CAtlDllModuleT< CsimplefishModule >
{
public :
	DECLARE_LIBID(LIBID_simplefishLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_SIMPLEFISH, "{27881840-98B6-4089-B04F-5FF9BAD48323}")
};

extern class CsimplefishModule _AtlModule;

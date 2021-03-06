//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Deer_Enum_LogEnumWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Deer.Enum.LogEnum));
		L.RegVar("DisableAllLogs", new LuaCSFunction(get_DisableAllLogs), null);
		L.RegVar("EnableAllLogs", new LuaCSFunction(get_EnableAllLogs), null);
		L.RegVar("EnableDebugAndAboveLogs", new LuaCSFunction(get_EnableDebugAndAboveLogs), null);
		L.RegVar("EnableInfoAndAboveLogs", new LuaCSFunction(get_EnableInfoAndAboveLogs), null);
		L.RegVar("EnableWarningAndAboveLogs", new LuaCSFunction(get_EnableWarningAndAboveLogs), null);
		L.RegVar("EnableErrorAndAboveLogs", new LuaCSFunction(get_EnableErrorAndAboveLogs), null);
		L.RegVar("EnableFatalAndAboveLogs", new LuaCSFunction(get_EnableFatalAndAboveLogs), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<Deer.Enum.LogEnum>.Check = CheckType;
		StackTraits<Deer.Enum.LogEnum>.Push = Push;
	}

	static void Push(IntPtr L, Deer.Enum.LogEnum arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_Deer_Enum_LogEnum = typeof(Deer.Enum.LogEnum);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_Deer_Enum_LogEnum, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DisableAllLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.DisableAllLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableAllLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableAllLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableDebugAndAboveLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableDebugAndAboveLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableInfoAndAboveLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableInfoAndAboveLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableWarningAndAboveLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableWarningAndAboveLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableErrorAndAboveLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableErrorAndAboveLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableFatalAndAboveLogs(IntPtr L)
	{
		ToLua.Push(L, Deer.Enum.LogEnum.EnableFatalAndAboveLogs);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		Deer.Enum.LogEnum o = (Deer.Enum.LogEnum)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}


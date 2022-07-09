﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LogWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Log");
		L.RegFunction("ColorInfo", new LuaCSFunction(ColorInfo));
		L.RegFunction("ProtoColorInfo", new LuaCSFunction(ProtoColorInfo));
		L.RegFunction("Info", new LuaCSFunction(Info));
		L.RegFunction("Warning", new LuaCSFunction(Warning));
		L.RegFunction("Error", new LuaCSFunction(Error));
		L.RegFunction("DrawLine", new LuaCSFunction(DrawLine));
		L.RegFunction("DrawRay", new LuaCSFunction(DrawRay));
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorInfo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Color, string>(L, 1))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				Log.ColorInfo(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<ColorType, string>(L, 1))
			{
				ColorType arg0 = (ColorType)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				Log.ColorInfo(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Log.ColorInfo");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProtoColorInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ColorType arg0 = (ColorType)ToLua.CheckObject(L, 1, TypeTraits<ColorType>.type);
			int arg1 = (int)LuaDLL.luaL_checkinteger(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			Log.ProtoColorInfo(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Info(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				Log.Info(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Log.Info(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<string, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Log.Info(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, object, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Log.Info(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Log.Info(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Log.Info");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Warning(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				Log.Warning(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Log.Warning(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<string, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Log.Warning(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, object, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Log.Warning(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Log.Warning(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Log.Warning");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Error(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				Log.Error(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Log.Error(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<string, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Log.Error(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, object, object, object>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Log.Error(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Log.Error(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Log.Error");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawLine(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 6);
			UnityEngine.Color arg6 = ToLua.ToColor(L, 7);
			Log.DrawLine(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawRay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 6);
			UnityEngine.Color arg6 = ToLua.ToColor(L, 7);
			Log.DrawRay(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

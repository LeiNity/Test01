//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Deer_ProcedureChangeLuaWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Deer.ProcedureChangeLua), typeof(Deer.ProcedureBase));
		L.RegFunction("ChangeStateToMain", new LuaCSFunction(ChangeStateToMain));
		L.RegFunction("GetCurProcedureId", new LuaCSFunction(GetCurProcedureId));
		L.RegFunction("New", new LuaCSFunction(_CreateDeer_ProcedureChangeLua));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("UseNativeDialog", new LuaCSFunction(get_UseNativeDialog), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDeer_ProcedureChangeLua(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Deer.ProcedureChangeLua obj = new Deer.ProcedureChangeLua();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Deer.ProcedureChangeLua.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeStateToMain(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Deer.ProcedureChangeLua obj = (Deer.ProcedureChangeLua)ToLua.CheckObject<Deer.ProcedureChangeLua>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ChangeStateToMain(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurProcedureId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Deer.ProcedureChangeLua obj = (Deer.ProcedureChangeLua)ToLua.CheckObject<Deer.ProcedureChangeLua>(L, 1);
			string o = obj.GetCurProcedureId();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseNativeDialog(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Deer.ProcedureChangeLua obj = (Deer.ProcedureChangeLua)o;
			bool ret = obj.UseNativeDialog;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UseNativeDialog on a nil value");
		}
	}
}

